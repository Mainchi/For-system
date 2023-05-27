/*
 * Created by SharpDevelop.
 * User: Ralph
 * Date: 5/11/2023
 * Time: 4:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class LoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.TextBox passwordTb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usernameTB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.passwordTb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameTB = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(72, 8);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 32);
			this.label4.TabIndex = 10;
			this.label4.Text = "CAFE MANAGEMENT SYSTEM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gainsboro;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.passwordTb);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.usernameTB);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(276, 335);
			this.panel2.TabIndex = 11;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(88, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Location = new System.Drawing.Point(154, 297);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Register";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Gainsboro;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(71, 297);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "No Account?";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(93, 274);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Forgot Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(137, 217);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 50);
			this.button2.TabIndex = 17;
			this.button2.Text = "CLOSE";
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
			this.button1.Location = new System.Drawing.Point(31, 217);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 50);
			this.button1.TabIndex = 16;
			this.button1.Text = "LOG IN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// passwordTb
			// 
			this.passwordTb.Location = new System.Drawing.Point(69, 190);
			this.passwordTb.MaxLength = 20;
			this.passwordTb.Name = "passwordTb";
			this.passwordTb.PasswordChar = '*';
			this.passwordTb.Size = new System.Drawing.Size(144, 20);
			this.passwordTb.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(69, 165);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 22);
			this.label2.TabIndex = 14;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// usernameTB
			// 
			this.usernameTB.Location = new System.Drawing.Point(69, 136);
			this.usernameTB.MaxLength = 20;
			this.usernameTB.Name = "usernameTB";
			this.usernameTB.Size = new System.Drawing.Size(144, 20);
			this.usernameTB.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(69, 111);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 22);
			this.label1.TabIndex = 12;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(300, 400);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginFormMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginFormMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginFormMouseUp);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
