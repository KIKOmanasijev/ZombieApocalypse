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
            this.EnemiesText = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnemiesText
            // 
            this.EnemiesText.AutoSize = true;
            this.EnemiesText.BackColor = System.Drawing.Color.Transparent;
            this.EnemiesText.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemiesText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnemiesText.Location = new System.Drawing.Point(55, 21);
            this.EnemiesText.Name = "EnemiesText";
            this.EnemiesText.Size = new System.Drawing.Size(210, 27);
            this.EnemiesText.TabIndex = 1;
            this.EnemiesText.Text = "You killed: 10 Enemies";
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewGame.Location = new System.Drawing.Point(351, 217);
            this.NewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(160, 54);
            this.NewGame.TabIndex = 12;
            this.NewGame.Text = "Try Again";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(59, 217);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(169, 54);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.EnemiesText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.ResizeEnd += new System.EventHandler(this.GameOver_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EnemiesText;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Exit;
    }
}