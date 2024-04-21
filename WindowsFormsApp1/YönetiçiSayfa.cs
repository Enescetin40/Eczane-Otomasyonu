using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class YönetiçiSayfa : Form
    {
        public YönetiçiSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Depo depo = new Depo();
            depo.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            İşlem işlem = new İşlem();
            işlem.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tedarik td=new tedarik();
            td.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.ShowDialog();
            this.Hide();

        }

        private void YönetiçiSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
