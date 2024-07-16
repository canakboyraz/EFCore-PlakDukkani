using PlakDukkani.Context;
using PlakDukkani.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkani
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        AppDbContext context;

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            context = new AppDbContext();
            dgvAnaEkran.DataSource = context.Albums.ToList();
            dgvSatısDevam.DataSource = context.Albums.Where(x => x.SatisDevamMi == true).ToList();
            dgvSatısDurmus.DataSource = context.Albums.Where(x => x.SatisDevamMi == false).ToList();
            dgvSonAlbumler.DataSource = context.Albums.OrderByDescending(x => x.AlbumID).ToList();
            dgvIndırımAlbumler.DataSource = context.Albums.Where(x=>x.IndirimOrani>0).OrderByDescending(x => x.IndirimOrani).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAlbumAdi.Text != null && txtSanatciAdi.Text != null && txtFiyat.Text != null)
            {
                Album album = new Album();
                album.AlbumAdi = txtAlbumAdi.Text;
                album.SanatciAdi = txtSanatciAdi.Text;
                album.CıkısTarihi = dateTimePicker1.Value;
                album.IndirimOrani = Convert.ToInt32(txtIndırımOranı.Text);
                album.SatisDevamMi = rdbAktif.Checked == true ? true : false;


                if (Convert.ToDecimal(txtFiyat.Text) > 0)
                {
                    album.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    context.Albums.Add(album);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Fiyatı kontrol ediniz Doğru Biçimde giriniz");
                }

                dgvAnaEkran.DataSource = context.Albums.ToList();
            }
            else
            {
                MessageBox.Show("Girilen değerleri kontrol ediniz Hata !");
            }
        }

        private void dgvAnaEkran_SelectionChanged(object sender, EventArgs e)
        {


            if (dgvAnaEkran.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRow = dgvAnaEkran.SelectedRows[0];


                txtAlbumAdi.Text = selectRow.Cells[1].Value.ToString();
                txtSanatciAdi.Text = selectRow.Cells[2].Value.ToString();
                txtFiyat.Text = selectRow.Cells[4].Value.ToString();
                txtIndırımOranı.Text = selectRow.Cells[5].Value.ToString();


            }
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIndırımOranı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAlbumAdi.Text != null && txtSanatciAdi.Text != null && txtFiyat.Text != null)
            {
                DataGridViewRow selectRow = dgvAnaEkran.SelectedRows[0];
                int albumID = Convert.ToInt32(selectRow.Cells[0].Value.ToString());
                Album album1 = context.Albums.Find(albumID);


                album1.AlbumAdi = txtAlbumAdi.Text;
                album1.SanatciAdi = txtSanatciAdi.Text;
                album1.CıkısTarihi = dateTimePicker1.Value;
                album1.IndirimOrani = Convert.ToInt32(txtIndırımOranı.Text);
                album1.SatisDevamMi = rdbAktif.Checked == true ? true : false;


                if (Convert.ToDecimal(txtFiyat.Text) > 0)
                {
                    album1.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    context.Albums.Add(album1);
                    context.Update(album1);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Fiyatı kontrol ediniz Doğru Biçimde giriniz");
                }

                dgvAnaEkran.DataSource = context.Albums.ToList();
            }
            else
            {
                MessageBox.Show("Girilen değerleri kontrol ediniz Hata !");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAnaEkran.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvAnaEkran.SelectedRows)
                {
                    context.Albums.Remove((Album)row.DataBoundItem); // Seçilen satırın veri bağlı öğesine erişim
                }
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Silme Başarısız!");
            }

            dgvAnaEkran.DataSource = context.Albums.ToList();


        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            this.Hide();
            menu.ShowDialog();
            
        }
    }
}
