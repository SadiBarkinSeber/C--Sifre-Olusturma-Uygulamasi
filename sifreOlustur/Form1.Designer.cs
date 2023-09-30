namespace sifreOlustur
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
            this.btnUret = new System.Windows.Forms.Button();
            this.rtbSifreler = new System.Windows.Forms.RichTextBox();
            this.chbKucukHarf = new System.Windows.Forms.CheckBox();
            this.chbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chbRakam = new System.Windows.Forms.CheckBox();
            this.chbOzelKarakter = new System.Windows.Forms.CheckBox();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.BackColor = System.Drawing.Color.Transparent;
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(126, 361);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(169, 50);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = false;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click_1);
            // 
            // rtbSifreler
            // 
            this.rtbSifreler.BackColor = System.Drawing.Color.Gray;
            this.rtbSifreler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbSifreler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbSifreler.Location = new System.Drawing.Point(438, 12);
            this.rtbSifreler.Name = "rtbSifreler";
            this.rtbSifreler.Size = new System.Drawing.Size(350, 426);
            this.rtbSifreler.TabIndex = 2;
            this.rtbSifreler.Text = "";
            // 
            // chbKucukHarf
            // 
            this.chbKucukHarf.AutoSize = true;
            this.chbKucukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbKucukHarf.Location = new System.Drawing.Point(53, 74);
            this.chbKucukHarf.Name = "chbKucukHarf";
            this.chbKucukHarf.Size = new System.Drawing.Size(117, 24);
            this.chbKucukHarf.TabIndex = 3;
            this.chbKucukHarf.Text = "Küçük Harf";
            this.chbKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chbBuyukHarf
            // 
            this.chbBuyukHarf.AutoSize = true;
            this.chbBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbBuyukHarf.Location = new System.Drawing.Point(235, 74);
            this.chbBuyukHarf.Name = "chbBuyukHarf";
            this.chbBuyukHarf.Size = new System.Drawing.Size(117, 24);
            this.chbBuyukHarf.TabIndex = 4;
            this.chbBuyukHarf.Text = "Büyük Harf";
            this.chbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chbRakam
            // 
            this.chbRakam.AutoSize = true;
            this.chbRakam.BackColor = System.Drawing.Color.Transparent;
            this.chbRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbRakam.Location = new System.Drawing.Point(53, 143);
            this.chbRakam.Name = "chbRakam";
            this.chbRakam.Size = new System.Drawing.Size(84, 24);
            this.chbRakam.TabIndex = 5;
            this.chbRakam.Text = "Rakam";
            this.chbRakam.UseVisualStyleBackColor = false;
            // 
            // chbOzelKarakter
            // 
            this.chbOzelKarakter.AutoSize = true;
            this.chbOzelKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbOzelKarakter.Location = new System.Drawing.Point(235, 143);
            this.chbOzelKarakter.Name = "chbOzelKarakter";
            this.chbOzelKarakter.Size = new System.Drawing.Size(137, 24);
            this.chbOzelKarakter.TabIndex = 6;
            this.chbOzelKarakter.Text = "Özel Karakter";
            this.chbOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreSayisi.Location = new System.Drawing.Point(49, 233);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(109, 20);
            this.lblSifreSayisi.TabIndex = 7;
            this.lblSifreSayisi.Text = "Şifre Sayısı :";
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(20, 282);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(138, 20);
            this.lblSifreUzunlugu.TabIndex = 8;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu :";
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudSifreSayisi.Location = new System.Drawing.Point(164, 231);
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(174, 26);
            this.nudSifreSayisi.TabIndex = 9;
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(164, 282);
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(174, 26);
            this.nudSifreUzunlugu.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.nudSifreUzunlugu);
            this.groupBox1.Controls.Add(this.chbKucukHarf);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.chbBuyukHarf);
            this.groupBox1.Controls.Add(this.lblSifreUzunlugu);
            this.groupBox1.Controls.Add(this.chbRakam);
            this.groupBox1.Controls.Add(this.lblSifreSayisi);
            this.groupBox1.Controls.Add(this.chbOzelKarakter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 436);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARAMETRELER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbSifreler);
            this.Name = "Form1";
            this.Text = "Şifre Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.RichTextBox rtbSifreler;
        private System.Windows.Forms.CheckBox chbKucukHarf;
        private System.Windows.Forms.CheckBox chbBuyukHarf;
        private System.Windows.Forms.CheckBox chbRakam;
        private System.Windows.Forms.CheckBox chbOzelKarakter;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

