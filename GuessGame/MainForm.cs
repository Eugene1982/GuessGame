using System;
using System.Windows.Forms;
using GuessGame.Domain;
using GuessGame.Repository;

namespace GuessGame
{
    public partial class MainForm : Form
    {
        private IRepository repository;
        private IGuessNumber model;
        public MainForm(IRepository repository, IGuessNumber model)
        {
            this.repository = repository;
            this.model = model;
            InitializeComponent();
        }

       
        private void onguessClick(object sender, EventArgs e)
        {
            var result = model.Guess(int.Parse(guessInput.Text));
            if (result == GuessResult.Guessed)
            {
                MessageBox.Show("Congratulations! Try again now");
                repository.ClearIntentions();
            }

            if (result == GuessResult.TooManyAttempts)
            {
                MessageBox.Show("Game Over! Try again now");
                repository.ClearIntentions();
            }
            DisplayAttempts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fromLabel.Text = HiddenNumber.NumRange.MinValue.ToString();
            toLabel.Text = HiddenNumber.NumRange.MaxValue.ToString();
            DisplayAttempts();
        }

        private void DisplayAttempts()
        {
            attemptsLabel.Text = (3 - repository.GetIntentionsCount()).ToString();
        }
    }
}