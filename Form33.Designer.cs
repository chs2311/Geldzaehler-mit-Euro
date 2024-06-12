namespace Geldzähler_mit_Euro
{
    partial class Form33
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
            this.b = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kurs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(244, 27);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 23);
            this.b.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Von B zu A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Währung B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Währung A";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(12, 27);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 23);
            this.a.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Von A zu B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kurs
            // 
            this.kurs.Location = new System.Drawing.Point(138, 27);
            this.kurs.Name = "kurs";
            this.kurs.Size = new System.Drawing.Size(100, 23);
            this.kurs.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Wechselkurs";
            // 
            // Form33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 93);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kurs);
            this.Controls.Add(this.b);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 132);
            this.MinimumSize = new System.Drawing.Size(393, 132);
            this.Name = "Form33";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eigener Kurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox b;
        private Button button2;
        private Label label2;
        private Label label1;
        private TextBox a;
        private Button button1;
        private TextBox kurs;
        private Label label3;
    }
}