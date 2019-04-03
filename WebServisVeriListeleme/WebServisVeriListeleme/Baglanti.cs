using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace WebServisVeriListeleme
{
    public class Baglanti
    { // Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\GokhanSARICIOGLU\Desktop\ODEVLER\WebServisVeriListeleme\WebServisVeriListeleme\WebServisVeriListeleme\Database.mdb
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\GokhanSARICIOGLU\Desktop\ODEVLER\WebServisVeriListeleme\WebServisVeriListeleme\WebServisVeriListeleme\Database.mdb");
        public OleDbConnection BagAc()
        {
            baglanti.Open();
            return baglanti;
        }
        public void BagKapat()
        {
            baglanti.Close();
        }
    }
}