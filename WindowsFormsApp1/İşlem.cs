using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Enumaration;
using WindowsFormsApp1.Model;
using ZXing;

namespace WindowsFormsApp1
{
    public partial class İşlem : Form
    {
        int sayı1;
        int sayı2;
        int işlemtipi;
        public İşlem()
        {
            InitializeComponent();
            txtislem.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
      


        }

        private void secilentus(object sender, EventArgs e)
        {
            if(txtislem.Text == "0")
            {
                txtislem.Text = "";
            }
            txtislem.Text += ((Button)sender).Text;
        }

        private void txttemizle_Click(object sender, EventArgs e)
        {
            txtislem.Text = "0";
        }

        private void txttoplama_Click(object sender, EventArgs e)
        {
            işlemtipi = 1;
            sayı1=Convert.ToInt32(txtislem.Text);
            txtislem.Text = "0";
        }

        private void txtesittir_Click(object sender, EventArgs e)
        {
            if(işlemtipi == 1)
            {
                sayı2=Convert.ToInt32(txtislem.Text);
                txtislem.Text = (sayı1 + sayı2).ToString();
            }
            else if (işlemtipi == 2)
            {
                sayı2 = Convert.ToInt32(txtislem.Text);
                txtislem.Text=(sayı1/sayı2).ToString();
            }
            else if(işlemtipi==3)
            {
                sayı2=Convert.ToInt32(txtislem.Text);
                txtislem.Text=(sayı1*sayı2).ToString();
            }
            else if (işlemtipi == 4)
            {
                sayı2 = Convert.ToInt32((txtislem.Text));
                txtislem.Text = (sayı1 - sayı2).ToString();
            }
        }

        private void txtbolme_Click(object sender, EventArgs e)
        {
            işlemtipi = 2;
            sayı1 = Convert.ToInt32(txtislem.Text);
            txtislem.Text = "0";
        }

        private void txtcarpma_Click(object sender, EventArgs e)
        {
            işlemtipi = 3;
            sayı1 = Convert.ToInt32(txtislem.Text);
            txtislem.Text = "0";    
        }

        private void txtcıkarma_Click(object sender, EventArgs e)
        {
            işlemtipi = 4;
            sayı1=Convert.ToInt32(txtislem.Text);   
            txtislem.Text = "0";
        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        private void İşlem_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo camera in fic)
            {
                cmd_kamerasec.Items.Add(camera.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_kameraaç_Click(object sender, EventArgs e)
        {
            vcd= new VideoCaptureDevice(fic[cmd_kamerasec.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
      pctbox_kamera.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vcd.Stop();
            pctbox_kamera.Image = Image.FromFile(@"C:\Users\enese\OneDrive\Masaüstü\Eczane Otomasyonu Projem\Images\kamera.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pctbox_kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
             Result result=   reader.Decode((Bitmap)pctbox_kamera.Image);


                if(result != null)
                {
                     txtbarkod.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            SoundPlayer ses=new SoundPlayer();
            ses.SoundLocation = "barkod.wav";
            ses.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller kontrol=new controller();
            dataGridView1.DataSource=kontrol.receteBilgiGetir(txttc.Text,txtbarkod.Text);
        }
    }
}
