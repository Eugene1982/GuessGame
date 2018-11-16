using System;
using FluentAssertions;
using GuessGame.Domain;
using GuessGame.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GuessGameSpecs
{
    [TestClass]
    public class GuessGameSpecs
    {
        private int wrongAnswer = HiddenNumber.NumRange.MinValue + 1;
        private int outOfRangeAnswer = HiddenNumber.NumRange.MinValue - 1;
        private int rightAnswer = HiddenNumber.Value;

        [TestMethod]
        public void After_user_guesses_three_time_unluckly_then_game_is_over()
        {
            var repository = new InMemoryRepository();
            var guessnumber = new GuessNumber(repository);

            guessnumber.Guess(wrongAnswer);
            guessnumber.Guess(wrongAnswer);
            guessnumber.Guess(wrongAnswer);
            var result = guessnumber.Guess(wrongAnswer);

            result.Should().Be(GuessResult.TooManyAttempts);
        }

        [TestMethod]
        public void When_user_provides_correct_value_then_game_is_won()
        {
            var repository = new InMemoryRepository();
            var guessnumber = new GuessNumber(repository);
           
            var result = guessnumber.Guess(rightAnswer);

            result.Should().Be(GuessResult.Guessed);
        }

        [TestMethod]
        public void When_user_provides_not_correct_value_but_still_has_attempts_then_game_continues()
        {
            var repository = new InMemoryRepository();
            var guessnumber = new GuessNumber(repository);
           
            var result = guessnumber.Guess(wrongAnswer);

            result.Should().Be(GuessResult.Wrong);
        }

        [TestMethod]
        public void User_is_allowed_to_enter_only_values_within_the_range()
        {
            var repository = new InMemoryRepository();
            var guessnumber = new GuessNumber(repository);
           
            Action tryToGuess = () => guessnumber.Guess(outOfRangeAnswer);

            tryToGuess.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}