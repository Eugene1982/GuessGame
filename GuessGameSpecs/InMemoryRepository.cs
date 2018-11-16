using GuessGame.Repository;

namespace GuessGameSpecs
{
    class InMemoryRepository: IRepository
    {
        private int counter = 0;
        public int GetIntentionsCount()
        {
            return counter;
        }

        public void AddIntention()
        {
            counter++;
        }

        public void ClearIntentions()
        {
            counter = 0;
        }
    }
}
