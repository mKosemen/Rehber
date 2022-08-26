using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelDB
{
    public partial class Form1 : Form
    {
        RehberDBEntities db_;
        public Form1()
        {
            InitializeComponent();
            db_ = new RehberDBEntities();
            btnGüncelle.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = db_.Kisis.ToList();
        }
        private void checkBox1_Click(object sender, System.EventArgs e)
        {
            if (cbxSil.Checked)
            {
                btnGüncelle.Text = "SİL";
            }
            else
            {
                btnGüncelle.Text = "GÜNCELLE";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.Adı = txtEAd.Text;
            kisi.Soyadı = txtESoyad.Text;
            kisi.Şehir = Convert.ToInt32(txtESehir.Text);
            kisi.Telefon = txtETelefon.Text;

            db_.Kisis.Add(kisi);
            db_.SaveChanges();


            MessageBox.Show("Kayıt başarıyle eklenmiştir.");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Kisi kisi = db_.Kisis.Find(Convert.ToInt32(txtID.Text));
                if (kisi != null)
                {
                    dgvData.DataSource = db_.Kisis.Where(k => k.ID == kisi.ID).ToList();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            else if (txtAAd.Text != "")
            {
                dgvData.DataSource = db_.Kisis.Where(k => k.Adı == txtAAd.Text).ToList();
            }
            else if (txtASoyad.Text != "")
            {
                dgvData.DataSource = db_.Kisis.Where(k => k.Soyadı == txtASoyad.Text).ToList();
            }
            else if (txtASehir.Text != "")
            {
                int a = Convert.ToInt32(txtASehir.Text);
                bool result = db_.Kisis.Any(c => c.Şehir == a);
                if (result)
                {
                    dgvData.DataSource = db_.Kisis.Where(k => k.Şehir == a).ToList();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı.");
                }
            }
            else if (txtATelefon.Text != "")
            {
                dgvData.DataSource = db_.Kisis.Where(k => k.Telefon == txtATelefon.Text).ToList();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (cbxSil.Checked)
            {
                MessageBox.Show("Sildim sildim hade sildim...:)");
            }
            else
            {
                Kisi kisi = db_.Kisis.Find(Convert.ToInt32(txtGID.Text));
                kisi.Adı = txtGAd.Text;
                kisi.İkinci_Ad = txtİkinciAd.Text;
                kisi.Soyadı = txtGSoyad.Text;
                kisi.Şehir = Convert.ToInt32(txtGSehir.Text);
                kisi.Telefon = txtGTelefon.Text;
                db_.SaveChanges();
                dgvData.DataSource = db_.Kisis.ToList();
                btnGüncelle.Enabled = false;
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            Kisi kisi = db_.Kisis.Find(Convert.ToInt32(txtGID.Text));
            if (kisi!=null)
            {
                txtGAd.Text = kisi.Adı;
                txtİkinciAd.Text = kisi.İkinci_Ad;
                txtGSoyad.Text = kisi.Soyadı;
                txtGSehir.Text = kisi.Şehir.ToString();
                txtGTelefon.Text = kisi.Telefon;
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı.");
            }
            
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = db_.Kisis.ToList();
        }
    }
}