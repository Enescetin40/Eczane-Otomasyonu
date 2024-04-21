using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Enumaration;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Depo : Form
    {
        controller kontrol=new controller();
        public Depo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Depo_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = kontrol.ilaclarıgetir();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                ılacBilgi ıb=new ılacBilgi();
            ıb.ılacID=Convert.ToInt32(txtId.Text);
              ıb.ılacAdı=txtAdı.Text;
                ıb.ılacFiyatı = txtFiyat.Text;
                ıb.ılacStokM=txtStok.Text;
                ıb.ılacSTK = DateTime.Parse(dateTimePicker1.Text);
                loginStatus sonuc = kontrol.ılacEkle(ıb);
                if (sonuc == loginStatus.başarılı)
                {
                    MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi","Bilglendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dataGridView1.DataSource = kontrol.ilaclarıgetir();
                }
                else if(sonuc==loginStatus.eksikbilgi )
            {
                MessageBox.Show("Lütfen Bilgileri Tam Giriniz", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ılacBilgi ıb=new ılacBilgi();
            ıb.ılacAdı=txtAdı.Text;
            ıb.ılacFiyatı = txtFiyat.Text;
            ıb.ılacStokM= txtStok.Text;
            ıb.ılacSTK=DateTime.Parse(dateTimePicker1.Text);
            loginStatus sonuc = kontrol.ılacGüncelle(ıb);
            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi", "Bilglendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.ilaclarıgetir();
            }
            else if (sonuc == loginStatus.eksikbilgi  )
            {
                MessageBox.Show("Lütfen Bilgileri Tam Giriniz", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginStatus sonuc=kontrol.ilacSil(txtId.Text);
            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Kayıt Siliniyor Eminmisiniz?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.ilaclarıgetir();

            }
            else if(sonuc== loginStatus.eksikbilgi)
            {
                MessageBox.Show("Lütfen Bilgileri Tam Giriniz", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
