/*
 * Created by SharpDevelop.
 * User: user
 * Date: 5/20/2023
 * Time: 6:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class itemform
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox closePb;
		private System.Windows.Forms.DataGridView foodDGV;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemform));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.foodDGV = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.closePb = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.foodDGV);
			this.panel1.Location = new System.Drawing.Point(14, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(848, 409);
			this.panel1.TabIndex = 12;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Indigo;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtPrice);
			this.panel2.Controls.Add(this.deleteBtn);
			this.panel2.Controls.Add(this.updateBtn);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtQty);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(176, 392);
			this.panel2.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 25);
			this.button1.TabIndex = 21;
			this.button1.Text = "REFRESH";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Location = new System.Drawing.Point(120, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 50);
			this.button3.TabIndex = 20;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
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
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(16, 168);
			this.txtPrice.MaxLength = 4;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(144, 20);
			this.txtPrice.TabIndex = 11;
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceKeyPress);
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
			this.label1.Location = new System.Drawing.Point(16, 82);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Item Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(16, 106);
			this.txtName.MaxLength = 10;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(144, 20);
			this.txtName.TabIndex = 9;
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameKeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(16, 207);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 22);
			this.label3.TabIndex = 12;
			this.label3.Text = "Quantity";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(16, 229);
			this.txtQty.MaxLength = 4;
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(144, 20);
			this.txtQty.TabIndex = 13;
			this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtyKeyPress);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 146);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "Item Price";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// foodDGV
			// 
			this.foodDGV.AllowUserToAddRows = false;
			this.foodDGV.AllowUserToDeleteRows = false;
			this.foodDGV.AllowUserToResizeColumns = false;
			this.foodDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.foodDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.foodDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.foodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.foodDGV.BackgroundColor = System.Drawing.Color.White;
			this.foodDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.foodDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.foodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.foodDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.foodDGV.Location = new System.Drawing.Point(192, 8);
			this.foodDGV.MultiSelect = false;
			this.foodDGV.Name = "foodDGV";
			this.foodDGV.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.foodDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.foodDGV.RowHeadersVisible = false;
			this.foodDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.foodDGV.Size = new System.Drawing.Size(649, 393);
			this.foodDGV.TabIndex = 2;
			this.foodDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodDGVCellContentClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(264, 8);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(384, 30);
			this.label4.TabIndex = 14;
			this.label4.Text = "CAFE MANAGEMENT SYSTEM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// closePb
			// 
			this.closePb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closePb.Image = ((System.Drawing.Image)(resources.GetObject("closePb.Image")));
			this.closePb.Location = new System.Drawing.Point(832, 8);
			this.closePb.Name = "closePb";
			this.closePb.Size = new System.Drawing.Size(30, 30);
			this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePb.TabIndex = 13;
			this.closePb.TabStop = false;
			this.closePb.Click += new System.EventHandler(this.ClosePbClick);
			// 
			// itemform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(877, 466);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.closePb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "itemform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "itemform";
			this.Load += new System.EventHandler(this.ItemformLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemformMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemformMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemformMouseUp);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
