using PlakDukkani.Context;
using PlakDukkani.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        AppDbContext context;
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        public bool ValidatePassword(string password)
        {
            // Şifre uzunluğu kontrolü
            if (password.Length < 8)
                return false;

            // Büyük harf sayısı kontrolü
            int upperCaseCount = password.Count(char.IsUpper);
            if (upperCaseCount < 2)
                return false;

            // Küçük harf sayısı kontrolü
            int lowerCaseCount = password.Count(char.IsLower);
            if (lowerCaseCount < 3)
                return false;

            // Özel karakterler kontrolü
            char[] specialCharacters = { '!', ':', '+', '*' };
            int specialCharCount = password.Count(c => specialCharacters.Contains(c));
            if (specialCharCount < 2)
                return false;

            return true;
        }

        private void btnKayıtOl2_Click(object sender, EventArgs e)
        {
            try
            {
                using (context = new AppDbContext())
                {
                    var kullaniciAdiKontrol = context.Admins.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text).Count();
                    if (kullaniciAdiKontrol > 0)
                    {
                        MessageBox.Show("Kullanıcı adı daha önce alınmış başka bir kullanıcı adı seçin");
                    }
                    else if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        string password = txtSifre.Text;

                        if (ValidatePassword(password))
                        {
                            string pass = sha256_hash(txtSifre.Text);
                            Admin admin = new Admin();
                            admin.KullaniciAdi = txtKullaniciAdi.Text;
                            admin.Sifre = pass;
                            context.Admins.Add(admin);
                            context.SaveChanges();
                            MessageBox.Show("Şifre geçerli.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Giris giris = new Giris();
                            giris.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifre geçerli değil. Lütfen kriterleri kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler birbiri ile uyumsuz!");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtSifreKriter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Şifre kriterleri şunlardır:•En az 8 karakter uzunluğunda olmalıdır.•En az 2 büyük harf içermelidir.•En az 3 küçük harf içermelidir.•! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesini içermelidir. (Aynı karakterden birden fazla olabilir)");
        }

        private void ParolayıGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (ParolayıGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtSifreTekrar.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtSifreTekrar.PasswordChar = '*';
            }
        }
    }
}
