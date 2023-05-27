/*
 * Created by SharpDevelop.
 * User: Ralph
 * Date: 5/11/2023
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class AdminSection
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox closePb;
		private System.Windows.Forms.PictureBox adminsPb;
		private System.Windows.Forms.PictureBox logoutPb;
		private System.Windows.Forms.PictureBox historyPb;
		private System.Windows.Forms.PictureBox addAdminPb;
		private System.Windows.Forms.PictureBox addItemPb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox usersPb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSection));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.usersPb = new System.Windows.Forms.PictureBox();
			this.adminsPb = new System.Windows.Forms.PictureBox();
			this.logoutPb = new System.Windows.Forms.PictureBox();
			this.historyPb = new System.Windows.Forms.PictureBox();
			this.addAdminPb = new System.Windows.Forms.PictureBox();
			this.addItemPb = new System.Windows.Forms.PictureBox();
			this.closePb = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adminsPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoutPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.historyPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addAdminPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addItemPb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.usersPb);
			this.panel1.Controls.Add(this.adminsPb);
			this.panel1.Controls.Add(this.logoutPb);
			this.panel1.Controls.Add(this.historyPb);
			this.panel1.Controls.Add(this.addAdminPb);
			this.panel1.Controls.Add(this.addItemPb);
			this.panel1.Location = new System.Drawing.Point(16, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(848, 392);
			this.panel1.TabIndex = 0;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Indigo;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(56, 336);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 30);
			this.label9.TabIndex = 19;
			this.label9.Text = "ADD ADMIN";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Indigo;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(259, 336);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 30);
			this.label7.TabIndex = 17;
			this.label7.Text = "LOG OUT";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Indigo;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(664, 152);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 30);
			this.label5.TabIndex = 15;
			this.label5.Text = "VIEW USERS";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Indigo;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(464, 152);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 30);
			this.label3.TabIndex = 14;
			this.label3.Text = "VIEW ADMINS";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Indigo;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(256, 152);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 30);
			this.label2.TabIndex = 13;
			this.label2.Text = "SALES";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Indigo;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(56, 152);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 30);
			this.label1.TabIndex = 12;
			this.label1.Text = "FOOD";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// usersPb
			// 
			this.usersPb.BackColor = System.Drawing.Color.Silver;
			this.usersPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.usersPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.usersPb.Image = ((System.Drawing.Image)(resources.GetObject("usersPb.Image")));
			this.usersPb.Location = new System.Drawing.Point(664, 24);
			this.usersPb.Name = "usersPb";
			this.usersPb.Size = new System.Drawing.Size(125, 125);
			this.usersPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.usersPb.TabIndex = 9;
			this.usersPb.TabStop = false;
			this.usersPb.Click += new System.EventHandler(this.UsersPbClick);
			// 
			// adminsPb
			// 
			this.adminsPb.BackColor = System.Drawing.Color.Silver;
			this.adminsPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.adminsPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.adminsPb.Image = ((System.Drawing.Image)(resources.GetObject("adminsPb.Image")));
			this.adminsPb.Location = new System.Drawing.Point(464, 24);
			this.adminsPb.Name = "adminsPb";
			this.adminsPb.Size = new System.Drawing.Size(125, 125);
			this.adminsPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.adminsPb.TabIndex = 7;
			this.adminsPb.TabStop = false;
			this.adminsPb.Click += new System.EventHandler(this.AdminsPbClick);
			// 
			// logoutPb
			// 
			this.logoutPb.BackColor = System.Drawing.Color.Silver;
			this.logoutPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.logoutPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logoutPb.Image = ((System.Drawing.Image)(resources.GetObject("logoutPb.Image")));
			this.logoutPb.Location = new System.Drawing.Point(259, 208);
			this.logoutPb.Name = "logoutPb";
			this.logoutPb.Size = new System.Drawing.Size(125, 125);
			this.logoutPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoutPb.TabIndex = 6;
			this.logoutPb.TabStop = false;
			this.logoutPb.Click += new System.EventHandler(this.LogoutPbClick);
			// 
			// historyPb
			// 
			this.historyPb.BackColor = System.Drawing.Color.Silver;
			this.historyPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.historyPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.historyPb.Image = ((System.Drawing.Image)(resources.GetObject("historyPb.Image")));
			this.historyPb.Location = new System.Drawing.Point(256, 24);
			this.historyPb.Name = "historyPb";
			this.historyPb.Size = new System.Drawing.Size(125, 125);
			this.historyPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.historyPb.TabIndex = 5;
			this.historyPb.TabStop = false;
			this.historyPb.Click += new System.EventHandler(this.HistoryPbClick);
			// 
			// addAdminPb
			// 
			this.addAdminPb.BackColor = System.Drawing.Color.Silver;
			this.addAdminPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.addAdminPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addAdminPb.Image = ((System.Drawing.Image)(resources.GetObject("addAdminPb.Image")));
			this.addAdminPb.Location = new System.Drawing.Point(56, 208);
			this.addAdminPb.Name = "addAdminPb";
			this.addAdminPb.Size = new System.Drawing.Size(125, 125);
			this.addAdminPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.addAdminPb.TabIndex = 3;
			this.addAdminPb.TabStop = false;
			this.addAdminPb.Click += new System.EventHandler(this.AddAdminPbClick);
			// 
			// addItemPb
			// 
			this.addItemPb.BackColor = System.Drawing.Color.Silver;
			this.addItemPb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.addItemPb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addItemPb.Image = ((System.Drawing.Image)(resources.GetObject("addItemPb.Image")));
			this.addItemPb.Location = new System.Drawing.Point(56, 24);
			this.addItemPb.Name = "addItemPb";
			this.addItemPb.Size = new System.Drawing.Size(125, 125);
			this.addItemPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.addItemPb.TabIndex = 2;
			this.addItemPb.TabStop = false;
			this.addItemPb.Click += new System.EventHandler(this.AddItemPbClick);
			// 
			// closePb
			// 
			this.closePb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closePb.Image = ((System.Drawing.Image)(resources.GetObject("closePb.Image")));
			this.closePb.Location = new System.Drawing.Point(824, 8);
			this.closePb.Name = "closePb";
			this.closePb.Size = new System.Drawing.Size(40, 40);
			this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePb.TabIndex = 1;
			this.closePb.TabStop = false;
			this.closePb.Click += new System.EventHandler(this.ClosePbClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(264, 16);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(384, 30);
			this.label4.TabIndex = 11;
			this.label4.Text = "CAFE MANAGEMENT SYSTEM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AdminSection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(877, 466);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.closePb);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminSection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ADMIN PAGE";
			this.Load += new System.EventHandler(this.AdminSectionLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminSectionMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminSectionMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminSectionMouseUp);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usersPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adminsPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoutPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.historyPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addAdminPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addItemPb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
