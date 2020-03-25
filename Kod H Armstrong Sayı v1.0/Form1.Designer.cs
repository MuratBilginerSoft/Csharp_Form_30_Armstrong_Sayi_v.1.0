namespace Kod_H_Armstrong_Sayı_v1._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MTBSayi = new System.Windows.Forms.MaskedTextBox();
            this.BtnKntrl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources._10;
            this.pictureBox1.Location = new System.Drawing.Point(255, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources._13_Simge;
            this.pictureBox2.Location = new System.Drawing.Point(223, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources._01___Logo_2017;
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources.Başlıksız_1__2_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 37);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Industryolog Akademi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Armstrong Sayı v2.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "3 Basamaklı Sayı";
            // 
            // MTBSayi
            // 
            this.MTBSayi.Location = new System.Drawing.Point(163, 60);
            this.MTBSayi.Mask = "000";
            this.MTBSayi.Name = "MTBSayi";
            this.MTBSayi.Size = new System.Drawing.Size(93, 23);
            this.MTBSayi.TabIndex = 7;
            this.MTBSayi.Text = "000";
            // 
            // BtnKntrl
            // 
            this.BtnKntrl.BackColor = System.Drawing.Color.Transparent;
            this.BtnKntrl.BackgroundImage = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources.Buton;
            this.BtnKntrl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKntrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKntrl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnKntrl.Location = new System.Drawing.Point(32, 89);
            this.BtnKntrl.Name = "BtnKntrl";
            this.BtnKntrl.Size = new System.Drawing.Size(224, 35);
            this.BtnKntrl.TabIndex = 8;
            this.BtnKntrl.Text = "Kontrol Et";
            this.BtnKntrl.UseVisualStyleBackColor = false;
            this.BtnKntrl.Click += new System.EventHandler(this.BtnKntrl_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources._1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.LblSonuc);
            this.panel2.Location = new System.Drawing.Point(32, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 37);
            this.panel2.TabIndex = 5;
            // 
            // LblSonuc
            // 
            this.LblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.LblSonuc.ForeColor = System.Drawing.Color.Black;
            this.LblSonuc.Location = new System.Drawing.Point(3, 0);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(218, 37);
            this.LblSonuc.TabIndex = 4;
            this.LblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kod_H_Armstrong_Sayı_v1._0.Properties.Resources._45__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(289, 237);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnKntrl);
            this.Controls.Add(this.MTBSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTBSayi;
        private System.Windows.Forms.Button BtnKntrl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblSonuc;
    }
}

