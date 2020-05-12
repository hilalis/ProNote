using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProNote
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
	
			InitializeComponent();
			
		}
		void YeniToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Text = "Adsız Note - ProNote";
		}
		void FarklıKaydetToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{		
			saveFileDialog1.Filter = ".txt dosyası(*.txt)|*.txt|Tüm Dosyalar(*.)|*.";
		}
		void AçToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			   {
			   	try
			   	{
			   		richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
			   	}
			   	catch
			   	{
			   		try
			   		{
			   			richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);
			   		}
			   		catch
			   		{
			   			MessageBox.Show("Hata:Dosya açılamadı. Program bu dosya biçimini desteklemiyor.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			   		}
			   	}
			}
			}
		void CourierNewToolStripMenuItemClick(object sender, EventArgs e)
		{
		}
		void YazıTipiToolStripMenuItemClick(object sender, EventArgs e)
		{
			fontDialog1.ShowDialog();
			richTextBox1.SelectionFont = fontDialog1.Font;
		}
		void YazıRengiToolStripMenuItemClick(object sender, EventArgs e)
		{
			colorDialog1.Color = richTextBox1.SelectionColor;
			
			if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog1.Color != richTextBox1.SelectionColor)
			{
				richTextBox1.SelectionColor = colorDialog1.Color;
			}
		}
		void ConvertToCapitalToolStripMenuItemClick(object sender, EventArgs e)
		{
			string toUpper = richTextBox1.Text;
			richTextBox1.Text = toUpper.ToUpper();
			
		}
		void ConvertToToolStripMenuItemClick(object sender, EventArgs e)
		{
			string toLower = richTextBox1.Text;
			richTextBox1.Text = toLower.ToLower();
		}
		}
		

	}

