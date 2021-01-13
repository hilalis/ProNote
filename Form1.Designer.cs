/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: iso
 * Tarih: 23.11.2020
 * Zaman: 18:56
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
namespace ProNote
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(536, 193);
			this.label1.TabIndex = 0;
			this.label1.Text = "Developed by @hilalis\r\nEmail: hilalis@outlook.com.tr\r\nVisit our github adress plz" +
			"";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.button1.Location = new System.Drawing.Point(153, 163);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(191, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "Check Updates";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(153, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "updatechecked";
			this.label2.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(177, 241);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(145, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Download Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(245, 317);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(77, 88);
			this.webBrowser1.TabIndex = 4;
			this.webBrowser1.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(361, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 107);
			this.label3.TabIndex = 5;
			this.label3.Text = "<html>\r\n<head></head>\r\n<body>2.0</body>\r\n</html>";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 317);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(493, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "IMPORTANT NOTE: YOU NEED MINIMIUM 1 BYTES INTERNET SPEED FOR UPDATE SYSTEM.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 357);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Developed by @hilalis";
			this.Load += new System.EventHandler(this.Form1Load);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
