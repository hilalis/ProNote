using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
			this.Text = "Unnamed - ProNote";
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
			saveFileDialog1.Filter = "Text File(*.txt)|*.txt|All Files(*.)|*.";
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
			   			MessageBox.Show("Error:File load not completed during error. This file is dont supported.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		void BackColorToolStripMenuItemClick(object sender, EventArgs e)
		{
			colorDialog1.Color = richTextBox1.BackColor;
			
			if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog1.Color != richTextBox1.SelectionColor)
			{
				richTextBox1.BackColor = colorDialog1.Color;
			}			
		}
		
		void BiçimToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.Show();
		}
		
		void HelpToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
		}
		
		
			  
		
		
		
		void KesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void KopyalaToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void YapıştırToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void MenuSettingsToolStripMenuItemClick(object sender, EventArgs e)
		{
			colorDialog1.Color = richTextBox1.BackColor;
			
			if(colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && colorDialog1.Color != richTextBox1.SelectionColor)
			{
				 menuStrip1.BackColor = colorDialog1.Color;
			}	
		}
		
		void OpenStyleToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(openFileDialog2.ShowDialog() == DialogResult.OK)
			   {
			   	try
			   	{
			   		richTextBox1.LoadFile(openFileDialog2.FileName,RichTextBoxStreamType.PlainText);
			   	}
			   	catch
			   	{
			   		try
			   		{
			   			richTextBox1.LoadFile(openFileDialog2.FileName,RichTextBoxStreamType.RichText);
			   		}
			   		catch
			   		{
			   			MessageBox.Show("Error:File load not completed during error. This file is dont supported.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			   		}
			   	}
			}
			if(richTextBox1.Text == "WorkspaceColor = blue")
			{
				richTextBox1.BackColor = Color.Blue;
			}
			if(richTextBox1.Text == "WorkspaceColor = lseagreen")
			{
				richTextBox1.BackColor = Color.LightSeaGreen;
			}
			
		}
		
		void OpenFileDialog2FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		void PrinToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void CodingModeToolStripMenuItemClick(object sender, EventArgs e)
		{
richTextBox1.BackColor = Color.Black;
richTextBox1.ForeColor = Color.MediumOrchid; 
menuStrip1.BackColor = Color.MediumOrchid;
		}
		
		void AddAToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void UTF8ToolForLanguagesToolStripMenuItemClick(object sender, EventArgs e)
		{

			
		}
}
}
		
		


