/*
 * Created by SharpDevelop.
 * User: Ralph
 * Date: 5/12/2023
 * Time: 2:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class RegisterAdmin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox UpasswordTb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox usernameTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UnameTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox EmailTb;
		private System.Windows.Forms.Label label7;
		
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
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.EmailTb = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.UpasswordTb = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.usernameTb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UnameTb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(109, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 39);
			this.label4.TabIndex = 11;
			this.label4.Text = "ADD ADMIN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.EmailTb);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.UpasswordTb);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.usernameTb);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.UnameTb);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(13, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 320);
			this.panel2.TabIndex = 3;
			// 
			// EmailTb
			// 
			this.EmailTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EmailTb.Location = new System.Drawing.Point(168, 200);
			this.EmailTb.MaxLength = 30;
			this.EmailTb.Name = "EmailTb";
			this.EmailTb.Size = new System.Drawing.Size(186, 25);
			this.EmailTb.TabIndex = 29;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Gainsboro;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(13, 197);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 22);
			this.label7.TabIndex = 28;
			this.label7.Text = "Email";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(192, 256);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 50);
			this.button2.TabIndex = 27;
			this.button2.Text = "BACK";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Green;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(17, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 50);
			this.button1.TabIndex = 26;
			this.button1.Text = "CREATE ACCOUNT";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// UpasswordTb
			// 
			this.UpasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UpasswordTb.Location = new System.Drawing.Point(168, 144);
			this.UpasswordTb.MaxLength = 20;
			this.UpasswordTb.Name = "UpasswordTb";
			this.UpasswordTb.Size = new System.Drawing.Size(186, 25);
			this.UpasswordTb.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gainsboro;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(13, 141);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 22);
			this.label5.TabIndex = 20;
			this.label5.Text = "Password";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// usernameTb
			// 
			this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.usernameTb.Location = new System.Drawing.Point(168, 87);
			this.usernameTb.MaxLength = 20;
			this.usernameTb.Name = "usernameTb";
			this.usernameTb.Size = new System.Drawing.Size(186, 25);
			this.usernameTb.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Gainsboro;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(13, 84);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 22);
			this.label2.TabIndex = 18;
			this.label2.Text = "Username";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UnameTb
			// 
			this.UnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UnameTb.Location = new System.Drawing.Point(168, 35);
			this.UnameTb.MaxLength = 20;
			this.UnameTb.Name = "UnameTb";
			this.UnameTb.Size = new System.Drawing.Size(186, 25);
			this.UnameTb.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Gainsboro;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(13, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 22);
			this.label1.TabIndex = 16;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RegisterAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(400, 389);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RegisterAdmin";
			this.Text = "RegisterAdmin";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterAdminMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterAdminMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterAdminMouseUp);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
