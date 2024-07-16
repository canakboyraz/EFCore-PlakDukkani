using PlakDukkani.Context;
using System.Security.Cryptography;
using System.Text;

namespace PlakDukkani
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        AppDbContext context;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.ShowDialog();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                using (context = new AppDbContext())
                {
                    string password = sha256_hash(txtSifre.Text);
                    var user = context.Admins.Where(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == password).Count();
                    if (user > 0)
                    {
                        AnaMenu anaMenu = new AnaMenu();
                        anaMenu.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriþ Hatasý");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chcSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';          
            }
            else
            {
                txtSifre.PasswordChar = '*';     
            }
        }
    }
}
