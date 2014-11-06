/*
 * SharpDevelop Tarafından Oluşturulmuşdur.
 * Kullanıcı: eczacılık
 * Tarih: 06.11.2014
 * Zaman: 14:01
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace tarayicim
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public MainForm form;
		private string hm;
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");
        
            foreach (System.Xml.XmlNode favNode in favoriler.SelectNodes("/favoriler/favori"))
            {
                listBox1.Items.Add(favNode.Attributes["url"].InnerText);
            }
		}
		
		void remove_click(object sender, EventArgs e)
		{
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
            catch
            {
                MessageBox.Show("Bir yer imi seçmelisiniz!");
            }
		}
		
		void close_click(object sender, EventArgs e)
		{
			XmlDocument favoriler = new XmlDocument();
            favoriler.Load("favoriler.xml");
            hm = favoriler.SelectSingleNode("/favoriler/home").Attributes["url"].InnerText;

			System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter("favoriler.xml", null);
 
			writer.WriteStartElement("favoriler");
			
			writer.WriteStartElement("home");
			writer.WriteAttributeString("url", hm);
			writer.WriteEndElement();
			
			for (int i = 0; i < listBox1.Items.Count; i++)
			{
			    writer.WriteStartElement("favori");
			    writer.WriteAttributeString("url", listBox1.Items[i].ToString());
			    writer.WriteEndElement();
			}
			writer.WriteEndElement();
			writer.Close();
			this.Close();
		}
		
		void yerimiAc_click(object sender, EventArgs e)
		{
			form = new MainForm();
            form.webBrowser1.Navigate(listBox1.SelectedValue.ToString());
            this.Close();
		}
		
		void git_click(object sender, EventArgs e)
		{
			form = new MainForm();
            form.webBrowser1.Navigate(listBox1.SelectedItem.ToString());
            form.Show();
            this.Close();
		}
	}
}
