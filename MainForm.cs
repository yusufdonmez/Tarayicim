/*
 * SharpDevelop Tarafından Oluşturulmuşdur.
 * Kullanıcı: eczacılık
 * Tarih: 06.11.2014
 * Zaman: 12:09
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace tarayicim
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string Home;
		private void writeFile()
		{
            if (!File.Exists(Path.GetFullPath("favoriler.xml")))
            {
                XmlTextWriter xwriter = new XmlTextWriter("favoriler.xml", Encoding.UTF8);
                xwriter.WriteStartDocument();
                xwriter.WriteStartElement("favoriler");
                
                xwriter.WriteStartElement("home");
                xwriter.WriteAttributeString("url","www.google.com");
                xwriter.WriteString("home"); 
                xwriter.WriteEndElement();
                
                xwriter.WriteEndElement();
                xwriter.WriteEndDocument();
                xwriter.Close();
            }
            else if (File.Exists(Path.GetFullPath("favoriler.xml")))
            {
                
            }           
            XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");
            Home = favoriler.SelectSingleNode("/favoriler/home").Attributes["url"].InnerText;
            webBrowser1.Navigate(Home);
        }
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			writeFile();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void git_click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(adres.Text);
		}
		
		void yenile_click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}
		
		void yerimiekle_click(object sender, EventArgs e)
		{
			XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");

            try
            {
                XmlElement favori = favoriler.CreateElement("favori");
                favori.SetAttribute("url", webBrowser1.Url.AbsoluteUri);
                favoriler.DocumentElement.AppendChild(favori);
            }
            catch (Exception exp)
            {
                Console.Write(" errr", exp.Source);
            }
            favoriler.Save("favoriler.xml");
		}
		
		void ileri_click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}
		
		void geri_click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}
		
		void anasayfa_click(object sender, EventArgs e)
		{
			XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");
            Home = favoriler.SelectSingleNode("/favoriler/home").Attributes["url"].InnerText;
            webBrowser1.Navigate(Home);
		}
		
		void anasayfayap_click(object sender, EventArgs e)
		{
			XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");
            XmlElement home = (XmlElement)favoriler.SelectSingleNode("//home");
            home.SetAttribute("url", webBrowser1.Url.AbsoluteUri);

            favoriler.Save("favoriler.xml");
		}
		
		void hakkinda_click(object sender, EventArgs e)
		{
			MessageBox.Show("Yusuf DÖNMEZ\n148004116\nKasım 2014");
		}
		
		void kapat_click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void adresgit_click(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				webBrowser1.Navigate(adres.Text);
			}
		}
		
		void yerimleriAc_click(object sender, EventArgs e)
		{
			Form2 formYer = new Form2();
            formYer.Show();
		}
		
		void change_click(object sender, WebBrowserNavigatedEventArgs e)
		{
			adres.Text = webBrowser1.Url.AbsoluteUri;
		}
	}
}
