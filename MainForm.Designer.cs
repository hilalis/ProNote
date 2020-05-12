/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: posta
 * Tarih: 16.04.2019
 * Zaman: 18:21
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace ProNote
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem biçimToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem yazıTipiToolStripMenuItem;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStripMenuItem yazıRengiToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem convertToCapitalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertToToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem developingToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.biçimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToCapitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.biçimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.yazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yazıRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.developingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.dosyaToolStripMenuItem,
			this.biçimToolStripMenuItem,
			this.biçimToolStripMenuItem1,
			this.helpToolStripMenuItem,
			this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(389, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dosyaToolStripMenuItem
			// 
			this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.yeniToolStripMenuItem,
			this.açToolStripMenuItem,
			this.farklıKaydetToolStripMenuItem});
			this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
			this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.dosyaToolStripMenuItem.Text = "File";
			// 
			// yeniToolStripMenuItem
			// 
			this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
			this.yeniToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.yeniToolStripMenuItem.Text = "New";
			this.yeniToolStripMenuItem.Click += new System.EventHandler(this.YeniToolStripMenuItemClick);
			// 
			// açToolStripMenuItem
			// 
			this.açToolStripMenuItem.Name = "açToolStripMenuItem";
			this.açToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.açToolStripMenuItem.Text = "Open";
			this.açToolStripMenuItem.Click += new System.EventHandler(this.AçToolStripMenuItemClick);
			// 
			// farklıKaydetToolStripMenuItem
			// 
			this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
			this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.farklıKaydetToolStripMenuItem.Text = "Save";
			this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.FarklıKaydetToolStripMenuItemClick);
			// 
			// biçimToolStripMenuItem
			// 
			this.biçimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.kesToolStripMenuItem,
			this.kopyalaToolStripMenuItem,
			this.yapıştırToolStripMenuItem,
			this.convertToCapitalToolStripMenuItem,
			this.convertToToolStripMenuItem});
			this.biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
			this.biçimToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.biçimToolStripMenuItem.Text = "Layout";
			// 
			// kesToolStripMenuItem
			// 
			this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
			this.kesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.kesToolStripMenuItem.Text = "Cut";
			this.kesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			// 
			// kopyalaToolStripMenuItem
			// 
			this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
			this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.kopyalaToolStripMenuItem.Text = "Copy";
			// 
			// yapıştırToolStripMenuItem
			// 
			this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
			this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.yapıştırToolStripMenuItem.Text = "Paste";
			// 
			// convertToCapitalToolStripMenuItem
			// 
			this.convertToCapitalToolStripMenuItem.Name = "convertToCapitalToolStripMenuItem";
			this.convertToCapitalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.convertToCapitalToolStripMenuItem.Text = "Convert to capital";
			this.convertToCapitalToolStripMenuItem.Click += new System.EventHandler(this.ConvertToCapitalToolStripMenuItemClick);
			// 
			// convertToToolStripMenuItem
			// 
			this.convertToToolStripMenuItem.Name = "convertToToolStripMenuItem";
			this.convertToToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.convertToToolStripMenuItem.Text = "Convert to small letter";
			this.convertToToolStripMenuItem.Click += new System.EventHandler(this.ConvertToToolStripMenuItemClick);
			// 
			// biçimToolStripMenuItem1
			// 
			this.biçimToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.yazıTipiToolStripMenuItem,
			this.yazıRengiToolStripMenuItem});
			this.biçimToolStripMenuItem1.Name = "biçimToolStripMenuItem1";
			this.biçimToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
			this.biçimToolStripMenuItem1.Text = "Style";
			// 
			// yazıTipiToolStripMenuItem
			// 
			this.yazıTipiToolStripMenuItem.Name = "yazıTipiToolStripMenuItem";
			this.yazıTipiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.yazıTipiToolStripMenuItem.Text = "Yazı Tipi";
			this.yazıTipiToolStripMenuItem.Click += new System.EventHandler(this.YazıTipiToolStripMenuItemClick);
			// 
			// yazıRengiToolStripMenuItem
			// 
			this.yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
			this.yazıRengiToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
			this.yazıRengiToolStripMenuItem.Click += new System.EventHandler(this.YazıRengiToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.developingToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// developingToolStripMenuItem
			// 
			this.developingToolStripMenuItem.Name = "developingToolStripMenuItem";
			this.developingToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.developingToolStripMenuItem.Text = "Developing :)";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(389, 255);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 279);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ProNote";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
