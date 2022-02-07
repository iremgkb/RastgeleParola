namespace RastgeleParola
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
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkKucukHarf.Location = new System.Drawing.Point(51, 57);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(151, 33);
            this.chkKucukHarf.TabIndex = 1;
            this.chkKucukHarf.Text = "Küçük Harf";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // txtSifreler
            // 
            this.txtSifreler.Location = new System.Drawing.Point(403, 20);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSifreler.Size = new System.Drawing.Size(329, 387);
            this.txtSifreler.TabIndex = 2;
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBuyukHarf.Location = new System.Drawing.Point(51, 102);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(150, 33);
            this.chkBuyukHarf.TabIndex = 1;
            this.chkBuyukHarf.Text = "Büyük Harf";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkRakam.Location = new System.Drawing.Point(51, 146);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(110, 33);
            this.chkRakam.TabIndex = 1;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(123, 339);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(152, 42);
            this.btnUret.TabIndex = 3;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnuret_Click);
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOzelKarakter.Location = new System.Drawing.Point(51, 185);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(209, 33);
            this.chkOzelKarakter.TabIndex = 1;
            this.chkOzelKarakter.Text = "Özel Karakterler";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre Uzunluğu";
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudSifreSayisi.Location = new System.Drawing.Point(237, 243);
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(120, 30);
            this.nudSifreSayisi.TabIndex = 5;
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(237, 284);
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(120, 30);
            this.nudSifreUzunlugu.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSifreUzunlugu);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.chkKucukHarf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkBuyukHarf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkRakam);
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.chkOzelKarakter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 404);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametreler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 428);
            this.Controls.Add(this.txtSifreler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.TextBox txtSifreler;
        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

