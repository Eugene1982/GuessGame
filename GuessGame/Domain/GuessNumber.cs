using System;
using GuessGame.Repository;
using Sparrow;

namespace GuessGame.Domain
{
    public class GuessNumber: IGuessNumber
    {
        private readonly IRepository repository;
        public GuessNumber(IRepository repository)
        {
            this.repository = repository;
        }

        public GuessResult Guess(int number)
        {
            if (number < HiddenNumber.NumRange.MinValue || number > HiddenNumber.NumRange.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            var intentions = repository.GetIntentionsCount();

            if (intentions >= 3)
            {
                return GuessResult.TooManyAttempts;
            }

            if (number == HiddenNumber.Value)
            {
                repository.ClearIntentions();
                return GuessResult.Guessed;
            }

            repository.AddIntention();

            return GuessResult.Wrong;
        }
    }

    public enum GuessResult
    {
        Guessed,
        TooManyAttempts,
        Wrong
    }
}