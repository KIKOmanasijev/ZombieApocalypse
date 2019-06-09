namespace ZombieApocalypse
{
    partial class GameOver
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
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.EnemiesText = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverlabel.ForeColor = System.Drawing.Color.Red;
            this.gameoverlabel.Location = new System.Drawing.Point(117, 67);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(298, 58);
            this.gameoverlabel.TabIndex = 0;
            this.gameoverlabel.Text = "Game Over!";
            // 
            // EnemiesText
            // 
            this.EnemiesText.AutoSize = true;
            this.EnemiesText.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemiesText.Location = new System.Drawing.Point(215, 139);
            this.EnemiesText.Name = "EnemiesText";
            this.EnemiesText.Size = new System.Drawing.Size(131, 20);
            this.EnemiesText.TabIndex = 1;
            this.EnemiesText.Text = "You kill: 10 Enemies";
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(351, 217);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(160, 54);
            this.NewGame.TabIndex = 12;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(58, 217);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 54);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 317);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.EnemiesText);
            this.Controls.Add(this.gameoverlabel);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label EnemiesText;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
    }
}