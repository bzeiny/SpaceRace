
namespace SpaceRace
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endLabel = new System.Windows.Forms.Label();
            this.playAgainLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(180, 10);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(144, 33);
            this.endLabel.TabIndex = 0;
            this.endLabel.Text = "Game Over!";
            // 
            // playAgainLabel
            // 
            this.playAgainLabel.AutoSize = true;
            this.playAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.playAgainLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainLabel.ForeColor = System.Drawing.Color.White;
            this.playAgainLabel.Location = new System.Drawing.Point(180, 271);
            this.playAgainLabel.Name = "playAgainLabel";
            this.playAgainLabel.Size = new System.Drawing.Size(141, 33);
            this.playAgainLabel.TabIndex = 1;
            this.playAgainLabel.Text = "Play again?";
            // 
            // restartLabel
            // 
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(196, 106);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(111, 32);
            this.restartLabel.TabIndex = 2;
            this.restartLabel.Text = "Play Again!";
            this.restartLabel.UseVisualStyleBackColor = true;
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            this.restartLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.restartLabel_KeyDown);
            this.restartLabel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.restartLabel_KeyUp);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(196, 154);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 32);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "No, I quit!";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(227, 70);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(144, 33);
            this.winnerLabel.TabIndex = 4;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceRace.Properties.Resources.spaceBackground;
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.playAgainLabel);
            this.Controls.Add(this.endLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(500, 335);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label playAgainLabel;
        private System.Windows.Forms.Button restartLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label winnerLabel;
    }
}
