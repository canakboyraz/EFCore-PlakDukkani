namespace PlakDukkani
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnKayitOl = new Button();
            chcSifreGoster = new CheckBox();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(190, 247);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(230, 56);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giris Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(190, 155);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(230, 27);
            txtSifre.TabIndex = 2;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(190, 104);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(230, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 107);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 158);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(190, 319);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(230, 56);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // chcSifreGoster
            // 
            chcSifreGoster.AutoSize = true;
            chcSifreGoster.Location = new Point(255, 203);
            chcSifreGoster.Name = "chcSifreGoster";
            chcSifreGoster.Size = new Size(119, 24);
            chcSifreGoster.TabIndex = 5;
            chcSifreGoster.Text = "Sifreyi Goster";
            chcSifreGoster.UseVisualStyleBackColor = true;
            chcSifreGoster.CheckedChanged += chcSifreGoster_CheckedChanged;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(chcSifreGoster);
            Controls.Add(btnKayitOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(btnGirisYap);
            Name = "Giris";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label1;
        private Label label2;
        private Button btnKayitOl;
        private CheckBox chcSifreGoster;
    }
}
