namespace GuessGame.Domain
{
    public interface IGuessNumber
    {
        GuessResult Guess(int number);
    }
}