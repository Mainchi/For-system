/*
 * Created by SharpDevelop.
 * User: user
 * Date: 5/21/2023
 * Time: 4:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class admins
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView adminDGV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox closePb;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admins));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.adminDGV = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.closePb = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.adminDGV);
			this.panel1.Location = new System.Drawing.Point(14, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(848, 409);
			this.panel1.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Indigo;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtUser);
			this.panel2.Controls.Add(this.deleteBtn);
			this.panel2.Controls.Add(this.updateBtn);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtPass);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(176, 392);
			this.panel2.TabIndex = 16;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// label5
			// 
			this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(32, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "BACK";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(16, 147);
			this.txtUser.MaxLength = 20;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(144, 20);
			this.txtUser.TabIndex = 11;
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.ForeColor = System.Drawing.Color.White;
			this.deleteBtn.Location = new System.Drawing.Point(88, 280);
			this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(75, 50);
			this.deleteBtn.TabIndex = 15;
			this.deleteBtn.Text = "DELETE";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.DeleteBtnClick);
			// 
			// updateBtn
			// 
			this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateBtn.ForeColor = System.Drawing.Color.White;
			this.updateBtn.Location = new System.Drawing.Point(8, 280);
			this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(75, 50);
			this.updateBtn.TabIndex = 14;
			this.updateBtn.Text = "UPDATE";
			this.updateBtn.UseVisualStyleBackColor = false;
			this.updateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 61);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(16, 85);
			this.txtName.MaxLength = 20;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 20);
			this.txtName.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(16, 186);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 22);
			this.label3.TabIndex = 12;
			this.label3.Text = "Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(16, 208);
			this.txtPass.MaxLength = 20;
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(144, 20);
			this.txtPass.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 125);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "Username";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// adminDGV
			// 
			this.adminDGV.AllowUserToAddRows = false;
			this.adminDGV.AllowUserToDeleteRows = false;
			this.adminDGV.AllowUserToResizeColumns = false;
			this.adminDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.adminDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.adminDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.adminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.adminDGV.BackgroundColor = System.Drawing.Color.White;
			this.adminDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.adminDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.adminDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.adminDGV.Location = new System.Drawing.Point(192, 8);
			this.adminDGV.MultiSelect = false;
			this.adminDGV.Name = "adminDGV";
			this.adminDGV.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.adminDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.adminDGV.RowHeadersVisible = false;
			this.adminDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.adminDGV.Size = new System.Drawing.Size(649, 393);
			this.adminDGV.TabIndex = 2;
			this.adminDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminDGVCellContentClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(264, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(384, 30);
			this.label4.TabIndex = 17;
			this.label4.Text = "CAFE MANAGEMENT SYSTEM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closePb
			// 
			this.closePb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closePb.Image = ((System.Drawing.Image)(resources.GetObject("closePb.Image")));
			this.closePb.Location = new System.Drawing.Point(832, 9);
			this.closePb.Name = "closePb";
			this.closePb.Size = new System.Drawing.Size(30, 30);
			this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePb.TabIndex = 16;
			this.closePb.TabStop = false;
			this.closePb.Click += new System.EventHandler(this.ClosePbClick);
			// 
			// admins
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(877, 466);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.closePb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "admins";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "admins";
			this.Load += new System.EventHandler(this.AdminsLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminsMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminsMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminsMouseUp);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
