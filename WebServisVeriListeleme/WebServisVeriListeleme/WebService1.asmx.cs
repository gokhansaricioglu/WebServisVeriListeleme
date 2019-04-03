using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;
using System.Data;

namespace WebServisVeriListeleme
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Baglanti baglanti = new Baglanti();
        [WebMethod]
        public List<Veriler> VeriListele(string ad)
        {
            List<Veriler> verilerList = new List<Veriler>();
            OleDbCommand komut;
            if (ad == "")
            {
              komut = new OleDbCommand("select Id,Ad,Soyad from Userlar ", baglanti.BagAc());
                

            }
            else
            {
                komut = new OleDbCommand("select Id,Ad,Soyad from Userlar where Ad='" + ad + "'", baglanti.BagAc());
            }
            
            OleDbDataReader alinan_veri = komut.ExecuteReader();
            while (alinan_veri.Read())
            {
                verilerList.Add(new Veriler()
                {
                    Ad = alinan_veri.GetString(1),
                    Soyad = alinan_veri.GetString(2),
                   
                    Id = alinan_veri.GetInt32(0)
                });
            }
            baglanti.BagKapat();
            return verilerList;
        }
       
        [WebMethod]
        public void VeriEkle(string ad, string soyad)
        {
            OleDbCommand veriEkleKomut = new OleDbCommand("insert into Userlar(Ad,Soyad) values(@ad,@soyad)", baglanti.BagAc());
            veriEkleKomut.Parameters.AddWithValue("@ad", ad);
            veriEkleKomut.Parameters.AddWithValue("@soyad", soyad);
            veriEkleKomut.ExecuteNonQuery();
            baglanti.BagKapat();
        }
        [WebMethod]
        public void VeriSil(string ad)
        {
            OleDbCommand veriSilKomut = new OleDbCommand("delete from Userlar where  Ad='" + ad + "'", baglanti.BagAc());
            veriSilKomut.ExecuteNonQuery();
            baglanti.BagKapat();
        }
    }
}
