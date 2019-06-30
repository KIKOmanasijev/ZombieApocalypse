namespace ZombieApocalypse
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HeroHealth = new System.Windows.Forms.ToolStripProgressBar();
            this.kills = new System.Windows.Forms.ToolStripStatusLabel();
            this.levelText = new System.Windows.Forms.ToolStripStatusLabel();
            this.HeroName1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AmmoText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmmoText,
            this.toolStripStatusLabel1,
            this.HeroHealth,
            this.kills,
            this.levelText,
            this.HeroName1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1232, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.StatusStrip1_Paint);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 37);
            this.toolStripStatusLabel1.Text = "Health:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // HeroHealth
            // 
            this.HeroHealth.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HeroHealth.Name = "HeroHealth";
            this.HeroHealth.Size = new System.Drawing.Size(133, 36);
            this.HeroHealth.Click += new System.EventHandler(this.HeroHealth_Click);
            // 
            // kills
            // 
            this.kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kills.Name = "kills";
            this.kills.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.kills.Size = new System.Drawing.Size(184, 37);
            this.kills.Text = "Kills: 0";
            // 
            // levelText
            // 
            this.levelText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(100, 37);
            this.levelText.Text = "Level 1";
            // 
            // HeroName1
            // 
            this.HeroName1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.HeroName1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeroName1.Name = "HeroName1";
            this.HeroName1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.HeroName1.Size = new System.Drawing.Size(188, 37);
            this.HeroName1.Text = "Hero Name";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // AmmoText
            // 
            this.AmmoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AmmoText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AmmoText.Image = global::ZombieApocalypse.Properties.Resources.ammo_Image;
            this.AmmoText.Name = "AmmoText";
            this.AmmoText.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.AmmoText.Size = new System.Drawing.Size(256, 37);
            this.AmmoText.Text = "Ammo: 30";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel2.Image = global::ZombieApocalypse.Properties.Resources.right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(20, 37);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 554);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Zombie Apocalypse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel AmmoText;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripProgressBar HeroHealth;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel kills;
        private System.Windows.Forms.ToolStripStatusLabel levelText;
        private System.Windows.Forms.ToolStripStatusLabel HeroName1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

