using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enumaration;

namespace WindowsFormsApp1.Model
{
    public class receteBilgi
    {
        public int receteID { get; set; }
        public string ılacadı { get; set; }
        public int ılacFıyatı { get; set; }
        public string kullanımMiktarı { get; set; }
        public string musteriAdı { get; set; }
        public string musteriSoyadı { get; set; }
        public string adres { get; set; }
        public int ılacstokM { get; set; }
        public string tcno { get; set; }
        public DateTime tarıh { get; set; }
        public DateTime receteTarıh { get; set; }
        public loginStatus status { get; set; }



    }
}
