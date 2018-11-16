using System.Collections.Generic;

namespace GuessGame.Repository
{ 
    public interface IRepository
    {
        int GetIntentionsCount();
        void AddIntention();
        void ClearIntentions();
    }
}