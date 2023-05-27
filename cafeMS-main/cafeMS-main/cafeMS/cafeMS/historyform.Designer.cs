/*
 * Created by SharpDevelop.
 * User: user
 * Date: 5/20/2023
 * Time: 9:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class historyform
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox closePb;
		private System.Windows.Forms.DataGridView historyDGV;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox sortTb;
		public System.Windows.Forms.Label nameeLb;
		private System.Windows.Forms.Label label5;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historyform));
			this.historyDGV = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nameeLb = new System.Windows.Forms.Label();
			this.sortTb = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.closePb = new System.Windows.Forms.PictureBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			((System.ComponentModel.ISupportInitialize)(this.historyDGV)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
			this.SuspendLayout();
			// 
			// historyDGV
			// 
			this.historyDGV.AllowUserToAddRows = false;
			this.historyDGV.AllowUserToDeleteRows = false;
			this.historyDGV.AllowUserToResizeColumns = false;
			this.historyDGV.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.historyDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.historyDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.historyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.historyDGV.BackgroundColor = System.Drawing.Color.White;
			this.historyDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.historyDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.historyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.historyDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.historyDGV.Location = new System.Drawing.Point(8, 64);
			this.historyDGV.MultiSelect = false;
			this.historyDGV.Name = "historyDGV";
			this.historyDGV.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.historyDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.historyDGV.RowHeadersVisible = false;
			this.historyDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.historyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.historyDGV.Size = new System.Drawing.Size(833, 320);
			this.historyDGV.TabIndex = 2;
			this.historyDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryDGVCellContentClick);
			this.historyDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryDGVCellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.historyDGV);
			this.panel1.Location = new System.Drawing.Point(14, 49);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(848, 409);
			this.panel1.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(8, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 20;
			this.label5.Text = "BACK";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Indigo;
			this.panel2.Controls.Add(this.nameeLb);
			this.panel2.Controls.Add(this.sortTb);
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(832, 48);
			this.panel2.TabIndex = 15;
			// 
			// nameeLb
			// 
			this.nameeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameeLb.ForeColor = System.Drawing.Color.White;
			this.nameeLb.Location = new System.Drawing.Point(8, 16);
			this.nameeLb.Name = "nameeLb";
			this.nameeLb.Size = new System.Drawing.Size(56, 23);
			this.nameeLb.TabIndex = 16;
			this.nameeLb.Text = "Search";
			this.nameeLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sortTb
			// 
			this.sortTb.Location = new System.Drawing.Point(72, 16);
			this.sortTb.MaxLength = 20;
			this.sortTb.Name = "sortTb";
			this.sortTb.Size = new System.Drawing.Size(240, 20);
			this.sortTb.TabIndex = 14;
			this.sortTb.TextChanged += new System.EventHandler(this.SortTbTextChanged);
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
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// historyform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(877, 466);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.closePb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "historyform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "historyform";
			this.Load += new System.EventHandler(this.HistoryformLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HistoryformMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HistoryformMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HistoryformMouseUp);
			((System.ComponentModel.ISupportInitialize)(this.historyDGV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
