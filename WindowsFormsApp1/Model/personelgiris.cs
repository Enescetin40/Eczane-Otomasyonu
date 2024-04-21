using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enumaration;

namespace WindowsFormsApp1.Model
{
    public class personelgiris
    {

        public int pıd { get; set; }
        public string pisim { get; set; }
        public string psoyad { get; set; }
        public string ptcno { get; set; }

        public DateTime pdogumtarıh { get; set; }
        public string pcinsiyet { get; set; }

        public string ppozisyon { get; set; }
        public int pmaas { get; set; }
        public string ptelefono { get; set; }
        public loginStatus status { get; set; }





    }
}
