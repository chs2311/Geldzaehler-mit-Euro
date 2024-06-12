namespace Geldzähler_mit_Euro
{
    partial class Form11
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
            this.player = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.player.Location = new System.Drawing.Point(34, 149);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.Lime;
            this.pipe1.Location = new System.Drawing.Point(155, 223);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(100, 187);
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.BackColor = System.Drawing.Color.Lime;
            this.pipe2.Location = new System.Drawing.Point(474, 0);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 158);
            this.pipe2.TabIndex = 2;
            this.pipe2.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Green;
            this.ground.Location = new System.Drawing.Point(0, 371);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(671, 39);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // game
            // 
            this.game.Interval = 20;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "HighScore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 62);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game Over!";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 451);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.up);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox player;
        private PictureBox pipe1;
        private PictureBox pipe2;
        private PictureBox ground;
        private System.Windows.Forms.Timer game;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}