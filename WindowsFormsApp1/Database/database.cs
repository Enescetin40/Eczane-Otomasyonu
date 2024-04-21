using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enumaration;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Database
{
    public class database
    {
        int value;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        public database()
        {
            con=new SqlConnection(@"Data Source=MONSTERABRA\SQLEXPRESS03;Initial Catalog=Eczane;Integrated Security=True;Encrypt=False");

        }

        public personelgiris giris(string adi,string soyadi,string tcno)
        {
            cmd = new SqlCommand("select*from personel where personelAdı=@padı and personelSoyadı=@psoyad and personelTcNo=@ptcno;", con);
            con.Open();
            cmd.Parameters.AddWithValue("@padı", adi);
            cmd.Parameters.AddWithValue("@psoyad", soyadi);
            cmd.Parameters.AddWithValue("@ptcno", tcno);
            dr= cmd.ExecuteReader();
           
            if(dr.Read())
            {
                personelgiris pb = new personelgiris();
                pb.pıd = int.Parse(dr["personelID"].ToString());
                pb.pisim = dr["personelAdı"].ToString();
                pb.psoyad = dr["personelSoyadı"].ToString() ;
                pb.ptcno = dr["personelTcNo"].ToString();
                pb.pdogumtarıh = DateTime.Parse(dr["personelDogumTarıhı"].ToString());
                pb.pcinsiyet = dr["personelCınsıyet"].ToString();
                pb.ppozisyon = dr["personelPozisyon"].ToString();
                pb.pmaas = int.Parse(dr["personelMaas"].ToString());
                pb.ptelefono = dr["personelIletışımBılgılerı"].ToString();
                pb.status = loginStatus.başarılı;
                return pb;
            }
            else
            {
                personelgiris pb = new personelgiris();
                pb.status = loginStatus.başarısız;
                return pb;
            }
            con.Close();
        }
       

        public List<ılacBilgi> ilaclarıgetir()
        {
            List<ılacBilgi> bilgiler = new List<ılacBilgi>();
            con.Open();
            cmd = new SqlCommand("select*from ılac", con);
            dr= cmd.ExecuteReader();
           
        
            while (dr.Read())
            {
                ılacBilgi ıb = new ılacBilgi();

                ıb.ılacID = int.Parse(dr["ılacId"].ToString()) ;
                ıb.ılacAdı = dr["ılacAdı"].ToString() ;
                ıb.ılacFiyatı = dr["ılacFıyatı"].ToString();
                ıb.ılacStokM = dr["ılacStokMıktarı"].ToString() ;
                ıb.ılacSTK = DateTime.Parse(dr["ılacSKT"].ToString()) ;
                bilgiler.Add(ıb);
                
            }
         
            con.Close();
            return bilgiler;





        }
        public List<receteBilgi> receteBilgiGetir(string tcno,string barkod)
        {
            con .Open();
            string sql = "select m.musteriAdı,m.musteriSoyadı, ı.ılacAdı,ı.ılacFıyatı,ı.ılacStokMıktarı,ır.kullanımMıktarı,m.tcno from ılac ı,ılac_recete ır,musteri m,recete r where ı.ılacId=ır.ılacId and ır.receteId=r.receteId and r.musteriId=m.musteriId and m.tcno=@prm1 and r.barkod=@prm2;";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@prm1", tcno);
            cmd.Parameters.AddWithValue("@prm2", barkod);
            dr = cmd.ExecuteReader();
            List<receteBilgi> recetebilgi = new List<receteBilgi>();

            while (dr.Read()) 
            { 
            receteBilgi rb=new receteBilgi();
                rb.musteriAdı = dr["musteriAdı"].ToString();
                rb.musteriSoyadı = dr["musteriSoyadı"].ToString();
                rb.ılacadı = dr["ılacAdı"].ToString();
                rb.ılacFıyatı =int.Parse( dr["ılacFıyatı"].ToString());
                rb.ılacstokM = int.Parse(dr["ılacStokMıktarı"].ToString());
                rb.kullanımMiktarı = dr["kullanımMıktarı"].ToString();
                rb.tcno = dr["tcno"].ToString();
                 recetebilgi.Add(rb);
            }

            con.Close ();
            return recetebilgi;



        }

        public loginStatus ılacEkle(ılacBilgi ıb)
        {
            con.Open();
            cmd = new SqlCommand("insert into ılac(ılacId,ılacAdı,ılacFıyatı,ılacStokMıktarı,ılacSKT)values(@ılacId,@ılacadı,@ılacfiyat,@ılacstok,@stk);", con);
            cmd.Parameters.AddWithValue("@ılacId", ıb.ılacID);
            cmd.Parameters.AddWithValue("@ılacadı", ıb.ılacAdı);
            cmd.Parameters.AddWithValue("@ılacfiyat", ıb.ılacFiyatı);
            cmd.Parameters.AddWithValue("@ılacstok", ıb.ılacStokM);
            cmd.Parameters.AddWithValue("@stk", ıb.ılacSTK);
            value = cmd.ExecuteNonQuery();
            con.Close();
            if (value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }


         
        }
        public loginStatus ılacGüncelle(ılacBilgi ıb)
        {
            con.Open();
            cmd = new SqlCommand("update ılac set ılacAdı=@adı,ılacFıyatı=@fiyat,ılacStokMıktarı=@stkm,ılacSKT=@skt where ılacAdı=@adı;", con);
            cmd.Parameters.AddWithValue("@adı", ıb.ılacAdı);
            cmd.Parameters.AddWithValue("@fiyat", ıb.ılacFiyatı);
            cmd.Parameters.AddWithValue("@stkm", ıb.ılacStokM);
            cmd.Parameters.AddWithValue("@skt", ıb.ılacSTK);
            value= cmd.ExecuteNonQuery();
            con.Close() ;
            if(value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }

        }
        public  loginStatus ilacSil(string ıd)
        {
            con.Open();
            cmd = new SqlCommand("delete from ılac where ılacId=@ıd", con);
            cmd.Parameters.AddWithValue("@ıd", ıd);
            value= cmd.ExecuteNonQuery();
            con.Close();
            if (value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                
                    return loginStatus.başarısız;
                
            }


            
        }

        public List<personelBilgi> pbilgigetir()
        {
          
            cmd = new SqlCommand("select*from personel", con);
            con.Open();
            dr = cmd.ExecuteReader();
            List<personelBilgi>pbilgi= new List<personelBilgi>();   
            while(dr.Read())
            {
                personelBilgi pb= new personelBilgi();
                pb.pıd = int.Parse(dr["personelID"].ToString());
                pb.pisim = dr["personelAdı"].ToString();
                pb.psoyad = dr["personelSoyadı"].ToString() ;
                pb.ptcno = dr["personelTcNo"].ToString();
                pb.pdogumtarıh = DateTime.Parse(dr["personelDogumTarıhı"].ToString()) ;
                pb.pcinsiyet = dr["personelCınsıyet"].ToString();
                pb.ppozisyon = dr["personelPozisyon"].ToString();
                pb.pmaas = int.Parse(dr["personelMaas"].ToString());
                pb.ptelefono = dr["personelIletışımBılgılerı"].ToString();
                pbilgi.Add(pb);
            }
            con.Close();
            return pbilgi;
         
            
        }
        public loginStatus personelEkle(personelBilgi pb)
        {
    
            con.Open();
            cmd = new SqlCommand("insert into personel( personelAdı, personelSoyadı, personelTcNo, personelDogumTarıhı, personelCınsıyet, personelPozisyon, personelMaas, personelIletışımBılgılerı)values(@ad,@soyad,@tc,@dt,@cınsıyet,@pozisyon,@maas,@telefono)", con);
         
            cmd.Parameters.AddWithValue("@ad", pb.pisim);
            cmd.Parameters.AddWithValue("@soyad", pb.psoyad);
            cmd.Parameters.AddWithValue("@tc", pb.ptcno);
            cmd.Parameters.AddWithValue("@dt", pb.pdogumtarıh);
            cmd.Parameters.AddWithValue("@cınsıyet", pb.pcinsiyet);
            cmd.Parameters.AddWithValue("@pozisyon", pb.ppozisyon);
            cmd.Parameters.AddWithValue("@maas", pb.pmaas);
            cmd.Parameters.AddWithValue("@telefono", pb.ptelefono);
            int value=cmd.ExecuteNonQuery();
            con.Close();
            if (value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }

        }

        public loginStatus personelGuncelleme(personelBilgi pb)
        {
            con.Open();
            cmd = new SqlCommand("update personel set personelAdı=@padı,personelSoyadı=@psoyadı,personelTcNo=@tc,personelDogumTarıhı=@dt,personelCınsıyet=@cıns,personelPozisyon=@ppoz,personelMaas=@maas,personelIletışımBılgılerı=@tel where personelID=@ıd;", con);
                cmd.Parameters.AddWithValue("@ıd", pb.pıd);
            cmd.Parameters.AddWithValue("@padı", pb.pisim);
            cmd.Parameters.AddWithValue("@psoyadı",pb.psoyad);
            cmd.Parameters.AddWithValue("@tc", pb.ptcno);
            cmd.Parameters.AddWithValue("@dt", pb.pdogumtarıh);
            cmd.Parameters.AddWithValue("@cıns", pb.pcinsiyet);
            cmd.Parameters.AddWithValue("@ppoz", pb.ppozisyon);
            cmd.Parameters.AddWithValue("@maas", pb.pmaas);
            cmd.Parameters.AddWithValue("@tel", pb.ptelefono);
            
            int value= cmd.ExecuteNonQuery();
            con.Close();
            if(value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }
        }
        public loginStatus personelSilme(personelBilgi pb)
        {
            con.Open();
            cmd = new SqlCommand("delete from personel where personelID=@ıd",con);
            cmd.Parameters.AddWithValue("@ıd", pb.pıd);
            int value= cmd.ExecuteNonQuery();
            con.Close();
            if (value == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }
        }
        
        public List<tedarikBilgi> tedarikciGetir()
        {
            con.Open();
            string sql = "select*from tedarık;";
            SqlCommand cmd=new SqlCommand(sql,con);
            dr= cmd.ExecuteReader();    
            List<tedarikBilgi> td  = new List<tedarikBilgi>();

            while(dr.Read())
            {
                tedarikBilgi tb=new tedarikBilgi();
                tb.tId =Convert.ToInt32( dr["tedarıkcıId"].ToString());
                tb.tAdı = dr["tedarıkcAdı"].ToString();
                tb.tSoyadı = dr["tedarıkcıSoyadı"].ToString() ;
                tb.tTelefonNo = dr["telefonNo"].ToString();
                tb.tadres = dr["adres"].ToString();

                td.Add(tb);
            }
            con.Close();
            return td;
           
        }

        public loginStatus tedarikEkle(tedarikBilgi tb)
        {
            con.Open();
            string sql = "insert into tedarık(tedarıkcAdı,tedarıkcıSoyadı,telefonNo,adres)values(@prm1,@prm2,@prm3,@prm4);";
            SqlCommand cmd=new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@prm1", tb.tAdı);
            cmd.Parameters.AddWithValue("@prm2", tb.tSoyadı);
            cmd.Parameters.AddWithValue("@prm3",tb.tTelefonNo);
            cmd.Parameters.AddWithValue("@prm4", tb.tadres);
            int deger=cmd.ExecuteNonQuery();
            if (deger == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }
            con.Close() ;
        }

        public loginStatus tedarikGuncelle(tedarikBilgi tb)
        {
            con.Open() ;
            string sql = "update tedarık set tedarıkcAdı=@prm1,tedarıkcıSoyadı=@prm2,telefonNo=@prm3,adres=@prm4 set where tedarıkcıId=@prm5;";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@prm1", tb.tAdı);
            cmd.Parameters.AddWithValue("@prm2", tb.tSoyadı);
            cmd.Parameters.AddWithValue("@prm3", tb.tTelefonNo);
            cmd.Parameters.AddWithValue("@prm4", tb.tadres);
            int deger=cmd.ExecuteNonQuery();
            con.Close();
            if (deger == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }
           


        }

        public loginStatus tedarıkcıSilme(tedarikBilgi tb)
        {
            con.Open() ;
            string sql = "delete from tedarık where tedarıkcıId=@prm1;";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@prm1", tb.tId);
            int deger = cmd.ExecuteNonQuery();
            con.Close();
            if (deger == 1)
            {
                return loginStatus.başarılı;
            }
            else
            {
                return loginStatus.başarısız;
            }
        }

    }
}
