namespace PlakDukkani
{
    partial class KayitOl
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
            label2 = new Label();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnKayıtOl2 = new Button();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            txtSifreKriter = new Button();
            ParolayıGoster = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 123);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 9;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 72);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(204, 69);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(230, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(204, 120);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(230, 27);
            txtSifre.TabIndex = 2;
            // 
            // btnKayıtOl2
            // 
            btnKayıtOl2.Location = new Point(204, 254);
            btnKayıtOl2.Name = "btnKayıtOl2";
            btnKayıtOl2.Size = new Size(230, 56);
            btnKayıtOl2.TabIndex = 4;
            btnKayıtOl2.Text = "Kayıt Ol";
            btnKayıtOl2.UseVisualStyleBackColor = true;
            btnKayıtOl2.Click += btnKayıtOl2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 173);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 11;
            label3.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(204, 170);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(230, 27);
            txtSifreTekrar.TabIndex = 3;
            // 
            // txtSifreKriter
            // 
            txtSifreKriter.Location = new Point(204, 330);
            txtSifreKriter.Name = "txtSifreKriter";
            txtSifreKriter.Size = new Size(230, 43);
            txtSifreKriter.TabIndex = 12;
            txtSifreKriter.Text = "Sifre Kriterleri";
            txtSifreKriter.UseVisualStyleBackColor = true;
            txtSifreKriter.Click += txtSifreKriter_Click;
            // 
            // ParolayıGoster
            // 
            ParolayıGoster.AutoSize = true;
            ParolayıGoster.Location = new Point(255, 213);
            ParolayıGoster.Name = "ParolayıGoster";
            ParolayıGoster.Size = new Size(130, 24);
            ParolayıGoster.TabIndex = 13;
            ParolayıGoster.Text = "Parolayı Goster";
            ParolayıGoster.UseVisualStyleBackColor = true;
            ParolayıGoster.CheckedChanged += ParolayıGoster_CheckedChanged;
            // 
            // KayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 450);
            Controls.Add(ParolayıGoster);
            Controls.Add(txtSifreKriter);
            Controls.Add(label3);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(btnKayıtOl2);
            Name = "KayitOl";
            Text = "KayitOl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnKayıtOl2;
        private Label label3;
        private TextBox txtSifreTekrar;
        private Button txtSifreKriter;
        private CheckBox ParolayıGoster;
    }
}