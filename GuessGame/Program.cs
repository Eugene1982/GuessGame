using System;
using System.Windows.Forms;
using GuessGame.Domain;

namespace GuessGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var repository = new Repository.Repository();
            var model = new GuessNumber(repository);

            Application.Run(new MainForm(repository, model));
        }
    }
}