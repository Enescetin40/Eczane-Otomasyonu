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
    public partial class Form1 : Form
    {
        controller kontrol = new controller();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad=txtadı.Text;
            string soyad = txtsoyad.Text;
            string tc=txttcno.Text
       ;

            personelgiris pb= new personelgiris();
            personelgiris sonuc=kontrol.giris(ad,soyad,tc);
            if(sonuc != null &&sonuc.status==loginStatus.başarılı&&sonuc.ppozisyon== "İŞLEM")
            {
                İşlem işlem = new İşlem();
                işlem.ShowDialog();
                this.Hide();
            }
            else if(sonuc != null && sonuc.status == loginStatus.başarılı && sonuc.ppozisyon == "DEPO")
            {
                Depo depo= new Depo();  
                depo.ShowDialog(); 
                this.Hide();
            }
            else if(sonuc != null && sonuc.status == loginStatus.başarılı && sonuc.ppozisyon == "PATRON")
            {
                YönetiçiSayfa ys=new YönetiçiSayfa();
                ys.ShowDialog();    
                this.Hide();    
            }
            else if (sonuc != null && sonuc.status == loginStatus.başarılı && sonuc.ppozisyon == "TEDARİK")
            {
                tedarik td=new tedarik();
                td.ShowDialog();
            }
            else if (sonuc.status == loginStatus.başarısız)
            {
                MessageBox.Show("Lütfen bilgileri dogru giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri tam giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
