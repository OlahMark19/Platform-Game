namespace Platform_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlatformGame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartGame = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PlatformGame
            // 
            this.PlatformGame.AutoSize = true;
            this.PlatformGame.BackColor = System.Drawing.Color.Transparent;
            this.PlatformGame.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformGame.ForeColor = System.Drawing.Color.ForestGreen;
            this.PlatformGame.Location = new System.Drawing.Point(477, 159);
            this.PlatformGame.Name = "PlatformGame";
            this.PlatformGame.Size = new System.Drawing.Size(307, 56);
            this.PlatformGame.TabIndex = 0;
            this.PlatformGame.Text = "Platform Game";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartGame
            // 
            this.StartGame.AutoSize = true;
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.Font = new System.Drawing.Font("Hotel De Paris", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.StartGame.Location = new System.Drawing.Point(540, 302);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(180, 30);
            this.StartGame.TabIndex = 1;
            this.StartGame.Text = "Start Game";
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // Control
            // 
            this.Control.AutoSize = true;
            this.Control.BackColor = System.Drawing.Color.Transparent;
            this.Control.Font = new System.Drawing.Font("Hotel De Paris", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Control.Location = new System.Drawing.Point(557, 368);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(154, 30);
            this.Control.TabIndex = 2;
            this.Control.Text = "Controls";
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Hotel De Paris", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.Location = new System.Drawing.Point(605, 434);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 30);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 673);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.PlatformGame);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platform Game - Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlatformGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label StartGame;
        private System.Windows.Forms.Label Control;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Timer timer2;
    }
}

