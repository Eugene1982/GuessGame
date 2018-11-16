namespace GuessGame
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessInput)).BeginInit();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(154, 51);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.onguessClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attempts";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(57, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(53, 13);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "fromLabel";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(100, 9);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(42, 13);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "toLabel";
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(66, 24);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(13, 13);
            this.attemptsLabel.TabIndex = 6;
            this.attemptsLabel.Text = "3";
            // 
            // guessInput
            // 
            this.guessInput.Location = new System.Drawing.Point(15, 51);
            this.guessInput.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.guessInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(120, 20);
            this.guessInput.TabIndex = 7;
            this.guessInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "--";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 87);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessButton);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guessInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.NumericUpDown guessInput;
        private System.Windows.Forms.Label label6;
    }
}

