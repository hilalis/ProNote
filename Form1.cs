/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: iso
 * Tarih: 23.11.2020
 * Zaman: 18:56
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProNote
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string updata;
		void Button2Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("github.com/hilalis/ProNote");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate("http://chatting.byethost32.com/updatesystem.html");
updata = webBrowser1.DocumentText;
if(updata == "2.0")
{
	label2.Visible = true;
	label2.Text = "ProNote is up-to-date, thanks dude :)";
}
else
{
label2.Visible = true;
label2.Text = "Dude, you need to update ProNote for cool innovations 😎";
button2.Visible = true;
}
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
	}
}
