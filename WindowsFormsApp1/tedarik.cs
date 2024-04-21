using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class tedarik : Form
    {
        public tedarik()
        {
            InitializeComponent();
        }
        controller kontrol=new controller();

        private void tedarik_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = kontrol.tedarikciGetir();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tedarikBilgi tb=new tedarikBilgi();
            tb.tAdı=textBox2.Text;
            tb.tSoyadı=textBox3.Text;
            tb.tTelefonNo=textBox4.Text;
            tb.tadres=textBox5.Text;
            loginStatus sonuc = kontrol.tedarikEkle(tb);


            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Tedarikçi başarılı bir şekilde eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.tedarikciGetir();
            }
            else if (sonuc == loginStatus.başarısız)
            {
                MessageBox.Show("Tedarikçi eklenemdi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sonuc == loginStatus.eksikbilgi)
            {
                MessageBox.Show("Tedarikçi bilgilerini tam giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            tedarikBilgi tb = new tedarikBilgi();
            tb.tAdı = textBox2.Text;
            tb.tSoyadı = textBox3.Text;
            tb.tTelefonNo = textBox4.Text;
            tb.tadres = textBox5.Text;
            loginStatus sonuc = kontrol.tedarikGuncelle(tb);

            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Tedarikçi başarılı bir şekilde güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.tedarikciGetir();
            }
            else if (sonuc == loginStatus.başarısız)
            {
                MessageBox.Show("Tedarikçi güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sonuc == loginStatus.eksikbilgi)
            {
                MessageBox.Show("Tedarikçi bilgilerini tam giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tedarikBilgi tb = new tedarikBilgi();
            tb.tId = Convert.ToInt32(textBox1.Text);

            loginStatus sonuc = kontrol.tedarikGuncelle(tb);

            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Tedarikçi başarılı bir şekilde silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.tedarikciGetir();
            }
            else if (sonuc == loginStatus.başarısız)
            {
                MessageBox.Show("Tedarikçi silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
