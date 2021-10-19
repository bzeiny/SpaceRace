
namespace SpaceRace
{
    partial class MainScreen
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.spaceRaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(197, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 42);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(197, 190);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 42);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // spaceRaceLabel
            // 
            this.spaceRaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.spaceRaceLabel.Font = new System.Drawing.Font("Oswald SemiBold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceRaceLabel.ForeColor = System.Drawing.Color.White;
            this.spaceRaceLabel.Location = new System.Drawing.Point(47, 0);
            this.spaceRaceLabel.Name = "spaceRaceLabel";
            this.spaceRaceLabel.Size = new System.Drawing.Size(405, 63);
            this.spaceRaceLabel.TabIndex = 2;
            this.spaceRaceLabel.Text = "Space Race";
            this.spaceRaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceRace.Properties.Resources.spaceBackground;
            this.Controls.Add(this.spaceRaceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(500, 335);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label spaceRaceLabel;
    }
}
