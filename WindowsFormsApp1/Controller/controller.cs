using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Enumaration;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    public class controller
    {
        database data = new database();
        public personelgiris giris(string adi, string soyadi, string tcno)
        {
            personelgiris sonuc;
            if (!string.IsNullOrEmpty(adi) && !string.IsNullOrEmpty(soyadi) && !string.IsNullOrEmpty(tcno))
            {
                sonuc = data.giris(adi, soyadi, tcno);
                return sonuc;
            }
            else
            {
                personelgiris pb = new personelgiris();
                pb.status = loginStatus.eksikbilgi;
                return pb;
            }
        }
        
        public List<ılacBilgi> ilaclarıgetir()
        {
            return data.ilaclarıgetir();
        }
        public loginStatus ılacEkle(ılacBilgi ıb)
        {
            if (!string.IsNullOrEmpty(ıb.ılacAdı) && !string.IsNullOrEmpty(ıb.ılacFiyatı) && !string.IsNullOrEmpty(ıb.ılacStokM))
            {
                return data.ılacEkle(ıb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }

        }
        public loginStatus ılacGüncelle(ılacBilgi ıb)
        {
            if (!string.IsNullOrEmpty(ıb.ılacAdı) && !string.IsNullOrEmpty(ıb.ılacFiyatı) && !string.IsNullOrEmpty(ıb.ılacStokM))
            {
                return data.ılacGüncelle(ıb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }
        public loginStatus ilacSil(string ıd)
        {
            if (!string.IsNullOrEmpty(ıd))
            {
                return data.ilacSil(ıd);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }
        public List<personelBilgi> pbilgigetir()
        {
            return data.pbilgigetir();
        }
        public loginStatus personelEkle(personelBilgi pb)
        {
            if (!string.IsNullOrEmpty(pb.pisim) && !string.IsNullOrEmpty(pb.psoyad) && !string.IsNullOrEmpty(pb.ppozisyon) && !string.IsNullOrEmpty(pb.ptelefono) && !string.IsNullOrEmpty(pb.ptcno))
            {
                return data.personelEkle(pb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }

        public loginStatus personelGuncelleme(personelBilgi pb)
        {
            if (!string.IsNullOrEmpty(pb.pisim) && !string.IsNullOrEmpty(pb.psoyad) && !string.IsNullOrEmpty(pb.ppozisyon) && !string.IsNullOrEmpty(pb.ptelefono) && !string.IsNullOrEmpty(pb.ptcno))
            {
                return data.personelGuncelleme(pb);
            }

            else
            {
                return loginStatus.eksikbilgi;
            }

        }
        public loginStatus personelSilme(personelBilgi pb)
        {
            if (!string.IsNullOrEmpty(pb.pıd.ToString()))
            {
                return data.personelSilme(pb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }

        public List<receteBilgi> receteBilgiGetir(string tcno, string barkod)
        {
           return data.receteBilgiGetir(tcno, barkod);  

        }

        public List<tedarikBilgi> tedarikciGetir()
        {
            return data.tedarikciGetir();
        }

        public loginStatus tedarikEkle(tedarikBilgi tb)
        {
            if(!string.IsNullOrEmpty(tb.tAdı)&& !string.IsNullOrEmpty(tb.tSoyadı)&& !string.IsNullOrEmpty(tb.tadres)&& !string.IsNullOrEmpty(tb.tTelefonNo))
            {
                return data.tedarikEkle(tb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }


        public loginStatus tedarikGuncelle(tedarikBilgi tb)
        {
            if (!string.IsNullOrEmpty(tb.tAdı) && !string.IsNullOrEmpty(tb.tSoyadı) && !string.IsNullOrEmpty(tb.tadres) && !string.IsNullOrEmpty(tb.tTelefonNo))
            {
                return data.tedarikEkle(tb);
            }
            else
            {
                return loginStatus.eksikbilgi;
            }
        }

        public loginStatus tedarıkcıSilme(tedarikBilgi tb)
        {
            return data.tedarıkcıSilme(tb);
        }


    }
}