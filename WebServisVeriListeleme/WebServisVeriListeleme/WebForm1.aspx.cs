using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace WebServisVeriListeleme
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebServisVeriListeleme.ServiceReference1.WebService1SoapClient servisNesnesi = new ServiceReference1.WebService1SoapClient();
        Baglanti baglanti = new Baglanti();
        protected void Page_Load(object sender, EventArgs e)
        {
            //OleDbCommand komut = new OleDbCommand("select UserAd,UserSifre from Userlar where Id=1", baglanti.BagAc());
            //OleDbDataReader alinan_veri = komut.ExecuteReader();
            //Repeater1.DataSource = servisNesnesi.VeriListele(txtGoster.Text);
            //Repeater1.DataBind();
            //baglanti.BagKapat();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            servisNesnesi.VeriEkle(txtAd.Text,txtSoyad.Text);
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = true;
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        protected void btnGoster_Click(object sender, EventArgs e)
        {
           
            Repeater1.DataSource = servisNesnesi.VeriListele(txtGoster.Text);
            Repeater1.DataBind();
            txtGoster.Text = "";
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            servisNesnesi.VeriSil(txtSil.Text);
            txtSil.Text = "";
            Panel5.Visible = true;
            Panel2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel3.Visible = false;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel3.Visible=true;
            Panel2.Visible = false;
            Panel1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel3.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
            Panel1.Visible = true;
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel5.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Panel5.Visible = false;
        }

        
    }
}