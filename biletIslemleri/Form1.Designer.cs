
namespace biletIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtkoltuksay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSat = new System.Windows.Forms.Button();
            this.rdbSatİndirim = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnİptal = new System.Windows.Forms.Button();
            this.rdbİptalİndirim = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBosKoltuk = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.txtkoltuksay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon Oluştur";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(57, 198);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(96, 55);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtkoltuksay
            // 
            this.txtkoltuksay.Location = new System.Drawing.Point(115, 115);
            this.txtkoltuksay.Name = "txtkoltuksay";
            this.txtkoltuksay.Size = new System.Drawing.Size(100, 22);
            this.txtkoltuksay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Sayısı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBakiye);
            this.groupBox2.Controls.Add(this.lblBakiye);
            this.groupBox2.Location = new System.Drawing.Point(572, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye Öğren";
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(32, 85);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(142, 42);
            this.btnBakiye.TabIndex = 3;
            this.btnBakiye.Text = "Bakiye Sorgula";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(54, 47);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(88, 17);
            this.lblBakiye.TabIndex = 2;
            this.lblBakiye.Text = "....................";
            this.lblBakiye.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSat);
            this.groupBox3.Controls.Add(this.rdbSatİndirim);
            this.groupBox3.Location = new System.Drawing.Point(330, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 132);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet Sat";
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(48, 78);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(95, 48);
            this.btnSat.TabIndex = 1;
            this.btnSat.Text = "Bilet Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // rdbSatİndirim
            // 
            this.rdbSatİndirim.AutoSize = true;
            this.rdbSatİndirim.Location = new System.Drawing.Point(57, 35);
            this.rdbSatİndirim.Name = "rdbSatİndirim";
            this.rdbSatİndirim.Size = new System.Drawing.Size(76, 21);
            this.rdbSatİndirim.TabIndex = 0;
            this.rdbSatİndirim.TabStop = true;
            this.rdbSatİndirim.Text = "İndirimli";
            this.rdbSatİndirim.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnİptal);
            this.groupBox4.Controls.Add(this.rdbİptalİndirim);
            this.groupBox4.Location = new System.Drawing.Point(330, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 139);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilet İptal";
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(48, 85);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(95, 48);
            this.btnİptal.TabIndex = 3;
            this.btnİptal.Text = "Bilet İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // rdbİptalİndirim
            // 
            this.rdbİptalİndirim.AutoSize = true;
            this.rdbİptalİndirim.Location = new System.Drawing.Point(57, 43);
            this.rdbİptalİndirim.Name = "rdbİptalİndirim";
            this.rdbİptalİndirim.Size = new System.Drawing.Size(76, 21);
            this.rdbİptalİndirim.TabIndex = 2;
            this.rdbİptalİndirim.TabStop = true;
            this.rdbİptalİndirim.Text = "İndirimli";
            this.rdbİptalİndirim.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.lblBosKoltuk);
            this.groupBox5.Location = new System.Drawing.Point(572, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 132);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Boş Koltuk Öğren";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Boş Koltuk Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBosKoltuk
            // 
            this.lblBosKoltuk.AutoSize = true;
            this.lblBosKoltuk.Location = new System.Drawing.Point(54, 39);
            this.lblBosKoltuk.Name = "lblBosKoltuk";
            this.lblBosKoltuk.Size = new System.Drawing.Size(88, 17);
            this.lblBosKoltuk.TabIndex = 0;
            this.lblBosKoltuk.Text = "....................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bilet İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtkoltuksay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.RadioButton rdbSatİndirim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.RadioButton rdbİptalİndirim;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBosKoltuk;
    }
}

