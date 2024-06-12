namespace Geldzähler_mit_Euro_4._0
{
    partial class Form0
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
            this.fail2 = new System.Windows.Forms.PictureBox();
            this.fail1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.fail3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.DarkOrange;
            this.player.Location = new System.Drawing.Point(25, 162);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // fail2
            // 
            this.fail2.BackColor = System.Drawing.Color.Red;
            this.fail2.Location = new System.Drawing.Point(74, 276);
            this.fail2.Name = "fail2";
            this.fail2.Size = new System.Drawing.Size(100, 163);
            this.fail2.TabIndex = 2;
            this.fail2.TabStop = false;
            // 
            // fail1
            // 
            this.fail1.BackColor = System.Drawing.Color.Red;
            this.fail1.Location = new System.Drawing.Point(236, -7);
            this.fail1.Name = "fail1";
            this.fail1.Size = new System.Drawing.Size(100, 194);
            this.fail1.TabIndex = 4;
            this.fail1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Score:";
            // 
            // game
            // 
            this.game.Interval = 20;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // fail3
            // 
            this.fail3.BackColor = System.Drawing.Color.Lime;
            this.fail3.Location = new System.Drawing.Point(-3, 415);
            this.fail3.Name = "fail3";
            this.fail3.Size = new System.Drawing.Size(434, 36);
            this.fail3.TabIndex = 6;
            this.fail3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "GAME OVER";
            this.label2.Visible = false;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fail3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fail1);
            this.Controls.Add(this.fail2);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form0";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.up);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fail3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox player;
        private PictureBox fail2;
        private PictureBox fail1;
        private Label label1;
        private System.Windows.Forms.Timer game;
        private PictureBox fail3;
        private Label label2;
    }
}