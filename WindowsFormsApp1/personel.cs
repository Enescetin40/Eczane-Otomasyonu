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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        controller kontrol=new controller();
        private void personel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kontrol.pbilgigetir();
            cmbcinsiyet.Items.Add("ERKEK");
            cmbcinsiyet.Items.Add("KIZ");
            cmbpozison.Items.Add("İŞLEM");
            cmbpozison.Items.Add("DEPO");
            cmbpozison.Items.Add("TEDARİK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          personelBilgi pb=new personelBilgi();
          
            pb.pisim=txtadı.Text;
            pb.psoyad=txtsoyadı.Text;
            pb.ptcno=txttcno.Text;
            pb.pdogumtarıh = dateTimePicker1.Value;
            pb.pcinsiyet=cmbcinsiyet.SelectedItem.ToString();
            pb.ppozisyon=cmbpozison.SelectedItem.ToString();
            pb.pmaas=int.Parse(txtmaas.Text);
            pb.ptelefono = txttno.Text;
            loginStatus sonuc = kontrol.personelEkle(pb);
            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Personel başarılı bir şekilde eklendi","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource=kontrol.pbilgigetir();
            }
            else if(sonuc==loginStatus.başarısız)
            {
                MessageBox.Show("Personel eklenemdi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sonuc == loginStatus.eksikbilgi)
            {
                MessageBox.Show("Personel bilgilerini tam giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyadı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();    
            txttcno.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbcinsiyet.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbpozison.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmaas.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txttno.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelBilgi pb=new personelBilgi();
            pb.pıd=int.Parse(txtıd.Text);
            pb.pisim=txtadı.Text;
            pb.psoyad = txtsoyadı.Text;
            pb.ptcno = txttcno.Text;
            pb.pdogumtarıh = dateTimePicker1.Value;
            pb.pcinsiyet = cmbcinsiyet.Text;
            pb.ppozisyon=cmbpozison.Text;
            pb.pmaas = int.Parse(txtmaas.Text);
            pb.ptelefono = txttno.Text;

            loginStatus sonuc=kontrol.personelGuncelleme(pb);
            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Personel başarılı bir şekilde güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.pbilgigetir();
            }
            else if (sonuc == loginStatus.başarısız)
            {
                MessageBox.Show("Personel güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sonuc == loginStatus.eksikbilgi)
            {
                MessageBox.Show("Personel bilgilerini tam giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelBilgi pb=new personelBilgi();
            pb.pıd=int.Parse(txtıd.Text);
            loginStatus sonuc=kontrol.personelSilme(pb);
            if (sonuc == loginStatus.başarılı)
            {
                MessageBox.Show("Personel başarılı bir şekilde silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = kontrol.pbilgigetir();
            }
            else if (sonuc == loginStatus.başarısız)
            {
                MessageBox.Show("Personel silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sonuc == loginStatus.eksikbilgi)
            {
                MessageBox.Show("Personel bilgilerini tam giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
