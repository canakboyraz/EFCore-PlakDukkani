namespace PlakDukkani
{
    partial class AnaMenu
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
            dgvAnaEkran = new DataGridView();
            dgvSatısDurmus = new DataGridView();
            dgvSatısDevam = new DataGridView();
            dgvSonAlbumler = new DataGridView();
            dgvIndırımAlbumler = new DataGridView();
            txtAlbumAdi = new TextBox();
            txtSanatciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            rdbAktif = new RadioButton();
            rdbPasif = new RadioButton();
            btnEkle = new Button();
            btnSil = new Button();
            txtFiyat = new TextBox();
            txtIndırımOranı = new TextBox();
            btnGuncelle = new Button();
            btnYenile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnaEkran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatısDurmus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatısDevam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonAlbumler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIndırımAlbumler).BeginInit();
            SuspendLayout();
            // 
            // dgvAnaEkran
            // 
            dgvAnaEkran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnaEkran.Location = new Point(12, 12);
            dgvAnaEkran.Name = "dgvAnaEkran";
            dgvAnaEkran.RowHeadersWidth = 51;
            dgvAnaEkran.Size = new Size(841, 176);
            dgvAnaEkran.TabIndex = 0;
            dgvAnaEkran.SelectionChanged += dgvAnaEkran_SelectionChanged;
            // 
            // dgvSatısDurmus
            // 
            dgvSatısDurmus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatısDurmus.Location = new Point(12, 356);
            dgvSatısDurmus.Name = "dgvSatısDurmus";
            dgvSatısDurmus.RowHeadersWidth = 51;
            dgvSatısDurmus.Size = new Size(832, 97);
            dgvSatısDurmus.TabIndex = 1;
            // 
            // dgvSatısDevam
            // 
            dgvSatısDevam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatısDevam.Location = new Point(12, 479);
            dgvSatısDevam.Name = "dgvSatısDevam";
            dgvSatısDevam.RowHeadersWidth = 51;
            dgvSatısDevam.Size = new Size(832, 105);
            dgvSatısDevam.TabIndex = 2;
            // 
            // dgvSonAlbumler
            // 
            dgvSonAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonAlbumler.Location = new Point(12, 610);
            dgvSonAlbumler.Name = "dgvSonAlbumler";
            dgvSonAlbumler.RowHeadersWidth = 51;
            dgvSonAlbumler.Size = new Size(836, 108);
            dgvSonAlbumler.TabIndex = 3;
            // 
            // dgvIndırımAlbumler
            // 
            dgvIndırımAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIndırımAlbumler.Location = new Point(12, 744);
            dgvIndırımAlbumler.Name = "dgvIndırımAlbumler";
            dgvIndırımAlbumler.RowHeadersWidth = 51;
            dgvIndırımAlbumler.Size = new Size(836, 108);
            dgvIndırımAlbumler.TabIndex = 4;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(12, 237);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(125, 27);
            txtAlbumAdi.TabIndex = 1;
            // 
            // txtSanatciAdi
            // 
            txtSanatciAdi.Location = new Point(156, 237);
            txtSanatciAdi.Name = "txtSanatciAdi";
            txtSanatciAdi.Size = new Size(125, 27);
            txtSanatciAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 322);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 10;
            label1.Text = "Satışı durmuş albümler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 456);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 11;
            label2.Text = "Satışı devam eden albümler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 587);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 12;
            label3.Text = "En son eklenen 10 albüm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 721);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 13;
            label4.Text = "İndirimdeki albümler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 203);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 14;
            label5.Text = "Albüm Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 203);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 15;
            label6.Text = "Sanatcı/Grup Adı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 203);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 16;
            label7.Text = "Çıkış Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(297, 203);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 17;
            label8.Text = "Fiyat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(592, 203);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 18;
            label9.Text = "İndirim Oranı";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(438, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(726, 203);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 20;
            label10.Text = "Satış Durumu";
            // 
            // rdbAktif
            // 
            rdbAktif.AutoSize = true;
            rdbAktif.Location = new Point(717, 237);
            rdbAktif.Name = "rdbAktif";
            rdbAktif.Size = new Size(61, 24);
            rdbAktif.TabIndex = 21;
            rdbAktif.TabStop = true;
            rdbAktif.Text = "Aktif";
            rdbAktif.UseVisualStyleBackColor = true;
            // 
            // rdbPasif
            // 
            rdbPasif.AutoSize = true;
            rdbPasif.Location = new Point(784, 238);
            rdbPasif.Name = "rdbPasif";
            rdbPasif.Size = new Size(60, 24);
            rdbPasif.TabIndex = 22;
            rdbPasif.TabStop = true;
            rdbPasif.Text = "Pasif";
            rdbPasif.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 281);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(248, 29);
            btnEkle.TabIndex = 23;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(596, 281);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(248, 29);
            btnSil.TabIndex = 24;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(297, 235);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 3;
            txtFiyat.KeyPress += txtFiyat_KeyPress;
            // 
            // txtIndırımOranı
            // 
            txtIndırımOranı.Location = new Point(586, 236);
            txtIndırımOranı.Name = "txtIndırımOranı";
            txtIndırımOranı.Size = new Size(125, 27);
            txtIndırımOranı.TabIndex = 25;
            txtIndırımOranı.KeyPress += txtIndırımOranı_KeyPress;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(306, 281);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(248, 29);
            btnGuncelle.TabIndex = 27;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnYenile
            // 
            btnYenile.Location = new Point(306, 316);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(248, 29);
            btnYenile.TabIndex = 28;
            btnYenile.Text = "YENİLE";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 887);
            Controls.Add(btnYenile);
            Controls.Add(btnGuncelle);
            Controls.Add(txtIndırımOranı);
            Controls.Add(txtFiyat);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(rdbPasif);
            Controls.Add(rdbAktif);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSanatciAdi);
            Controls.Add(txtAlbumAdi);
            Controls.Add(dgvIndırımAlbumler);
            Controls.Add(dgvSonAlbumler);
            Controls.Add(dgvSatısDevam);
            Controls.Add(dgvSatısDurmus);
            Controls.Add(dgvAnaEkran);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnaEkran).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatısDurmus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatısDevam).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSonAlbumler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIndırımAlbumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAnaEkran;
        private DataGridView dgvSatısDurmus;
        private DataGridView dgvSatısDevam;
        private DataGridView dgvSonAlbumler;
        private DataGridView dgvIndırımAlbumler;
        private TextBox txtAlbumAdi;
        private TextBox txtSanatciAdi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private RadioButton rdbAktif;
        private RadioButton rdbPasif;
        private Button btnEkle;
        private Button btnSil;
        private TextBox txtFiyat;
        private TextBox txtIndırımOranı;
        private Button btnGuncelle;
        private Button btnYenile;
    }
}