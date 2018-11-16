using System.IO;

namespace GuessGame.Repository
{
    public class Repository : IRepository
    {
        private string filePath = @".\attempts.txt";

        public int GetIntentionsCount()
        {
            EnsureFileExists();
            var content = File.ReadAllText(filePath);
            int amount = string.IsNullOrWhiteSpace(content) ? 0 : int.Parse(content);
            return amount;
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
            }
        }

        public void AddIntention()
        {
            var amount = GetIntentionsCount();
            File.WriteAllText(filePath, (++amount).ToString());
        }

        public void ClearIntentions()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}