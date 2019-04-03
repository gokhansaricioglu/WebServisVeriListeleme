<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServisVeriListeleme.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 67px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>


                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" Text="Ekleme , Silme ve Listeleme Simülasyonuna Hoşgeldiniz" Font-Bold="True"></asp:Label>
                <br />
                <br />


                <asp:Panel ID="Panel3" runat="server">
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Adinizi Giriniz ="></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Soyadınızı Giriniz ="></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" Width="63px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listelemeye Git" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Silmeye Git" />
                </asp:Panel>
                <br />
                <br />
            </div>
            <div>
                <asp:Panel ID="Panel1" runat="server" Visible="False">
                    <asp:Label ID="Label3" runat="server" Text="Gösterilecek Kisinin Adini Girin   ( BOS BIRAKILIRSA BUTUN VERILER GELIR )"></asp:Label>
                    <br />
                    <br />
                    <asp:TextBox ID="txtGoster" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGoster" runat="server" Text="Göster" OnClick="btnGoster_Click" Width="72px" />
                    <br />
                    <table style="border:3px solid black;">
                        <tr>
                            <td class="auto-style1">ID</td>
                             <td>AD</td>
                             <td>SOYAD</td>
                        </tr>
                          <asp:Repeater ID="Repeater1" runat="server">
                              <ItemTemplate>
                                  <tr>
                                      <td><%#Eval("Id") %></td>
                                        <td><%#Eval("Ad") %></td>
                                       <td><%#Eval("Soyad") %></td>
                                  </tr>
                              </ItemTemplate>
                    </asp:Repeater>
                        <tr>
                            <td class="auto-style1">&nbsp;</td>
                        </tr>
                    </table>
                  
                    <br />
                    <br />
                    &nbsp;&nbsp;
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Ekleme Işlemi Yapmak Icin"></asp:Label>
&nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Tiklayin" />
                </asp:Panel>
                <br />
                <br />
            </div>
        <div>
            <asp:Panel ID="Panel2" runat="server" Visible="False">
                <asp:Label ID="Label4" runat="server" Text="Silinecek Kisinin Adini Girin"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="txtSil" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Sil" Width="49px" />
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Ekleme Işlemi Yapmak Icin"></asp:Label>
                &nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tiklayin" />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel4" runat="server" Visible="False">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="EKLEME ISLEMINIZ GERCEKLESTI"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Listeleme Islemine Git" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Silme Islemine Git" />
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel5" runat="server" Visible="False">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="SILME ISLEMINI GERCEKLESTIRDINIZ"></asp:Label>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Listeleme Islemine Git" Width="163px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Ekleme Islemine Git" />
            </asp:Panel>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.instagram.com/gokhansaricioglu/">GokhanSaricioglu INSTAGRAM</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
     </div>
    </form>
</body>
</html>
