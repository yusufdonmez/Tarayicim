/*
 * SharpDevelop Tarafından Oluşturulmuşdur.
 * Kullanıcı: eczacılık
 * Tarih: 06.11.2014
 * Zaman: 12:09
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace tarayicim
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.yerİmleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.anasayfaYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kapatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.adres = new System.Windows.Forms.TextBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.yerİmleriToolStripMenuItem1,
									this.anasayfaYapToolStripMenuItem,
									this.hakkındaToolStripMenuItem,
									this.kapatToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(952, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// yerİmleriToolStripMenuItem1
			// 
			this.yerİmleriToolStripMenuItem1.Name = "yerİmleriToolStripMenuItem1";
			this.yerİmleriToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
			this.yerİmleriToolStripMenuItem1.Text = "Yer İmleri";
			this.yerİmleriToolStripMenuItem1.Click += new System.EventHandler(this.yerimleriAc_click);
			// 
			// anasayfaYapToolStripMenuItem
			// 
			this.anasayfaYapToolStripMenuItem.Name = "anasayfaYapToolStripMenuItem";
			this.anasayfaYapToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.anasayfaYapToolStripMenuItem.Text = "Anasayfa Yap";
			this.anasayfaYapToolStripMenuItem.Click += new System.EventHandler(this.anasayfayap_click);
			// 
			// hakkındaToolStripMenuItem
			// 
			this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
			this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.hakkındaToolStripMenuItem.Text = "Hakkında";
			this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkinda_click);
			// 
			// kapatToolStripMenuItem1
			// 
			this.kapatToolStripMenuItem1.Name = "kapatToolStripMenuItem1";
			this.kapatToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
			this.kapatToolStripMenuItem1.Text = "Kapat";
			this.kapatToolStripMenuItem1.Click += new System.EventHandler(this.kapat_click);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(0, 27);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 1;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.anasayfa_click);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(31, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(25, 25);
			this.button2.TabIndex = 2;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.geri_click);
			// 
			// button3
			// 
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(62, 27);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(25, 25);
			this.button3.TabIndex = 3;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.ileri_click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(896, 27);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(25, 25);
			this.button4.TabIndex = 4;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.yenile_click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(927, 27);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(25, 25);
			this.button5.TabIndex = 5;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.yerimiekle_click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(865, 27);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(25, 25);
			this.button6.TabIndex = 6;
			this.button6.Tag = "git";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.git_click);
			// 
			// adres
			// 
			this.adres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.adres.Location = new System.Drawing.Point(96, 29);
			this.adres.Name = "adres";
			this.adres.Size = new System.Drawing.Size(763, 20);
			this.adres.TabIndex = 7;
			this.adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adresgit_click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(4, 56);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(948, 498);
			this.webBrowser1.TabIndex = 8;
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.change_click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 566);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.adres);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Tarayicim - Yusuf Dönmez";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox adres;
		public System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anasayfaYapToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yerİmleriToolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
