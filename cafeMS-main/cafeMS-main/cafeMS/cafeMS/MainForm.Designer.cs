/*
 * Created by SharpDevelop.
 * User: Ralph
 * Date: 5/10/2023
 * Time: 12:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnPay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox closePb;
		public System.Windows.Forms.Label nameeLb;
		public System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox paymentTb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label changelbl;
		private System.Windows.Forms.Label LabelChange;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnPay = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.closePb = new System.Windows.Forms.PictureBox();
			this.nameeLb = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.paymentTb = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.changelbl = new System.Windows.Forms.Label();
			this.LabelChange = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 71);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(542, 397);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGridView1.Location = new System.Drawing.Point(560, 71);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(305, 257);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnPay
			// 
			this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPay.BackColor = System.Drawing.Color.Green;
			this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnPay.ForeColor = System.Drawing.Color.White;
			this.btnPay.Location = new System.Drawing.Point(560, 439);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(305, 57);
			this.btnPay.TabIndex = 2;
			this.btnPay.Text = "PAY";
			this.btnPay.UseVisualStyleBackColor = false;
			this.btnPay.Click += new System.EventHandler(this.BtnPayClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(698, 331);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "Total";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(560, 331);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 40);
			this.label2.TabIndex = 4;
			this.label2.Text = "₱";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateLabel
			// 
			this.dateLabel.ForeColor = System.Drawing.Color.White;
			this.dateLabel.Location = new System.Drawing.Point(560, 48);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(100, 23);
			this.dateLabel.TabIndex = 12;
			this.dateLabel.Text = "Date";
			this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dateLabel.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(280, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(342, 22);
			this.label4.TabIndex = 11;
			this.label4.Text = "CAFE MANAGEMENY SYSTEM";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(12, 474);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "LOG OUT";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// closePb
			// 
			this.closePb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closePb.Image = ((System.Drawing.Image)(resources.GetObject("closePb.Image")));
			this.closePb.Location = new System.Drawing.Point(830, 9);
			this.closePb.Name = "closePb";
			this.closePb.Size = new System.Drawing.Size(40, 40);
			this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePb.TabIndex = 14;
			this.closePb.TabStop = false;
			this.closePb.Click += new System.EventHandler(this.ClosePbClick);
			// 
			// nameeLb
			// 
			this.nameeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameeLb.ForeColor = System.Drawing.Color.White;
			this.nameeLb.Location = new System.Drawing.Point(88, 40);
			this.nameeLb.Name = "nameeLb";
			this.nameeLb.Size = new System.Drawing.Size(144, 23);
			this.nameeLb.TabIndex = 15;
			this.nameeLb.Text = "NAME";
			this.nameeLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(14, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Welcome,";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// paymentTb
			// 
			this.paymentTb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
			this.paymentTb.Location = new System.Drawing.Point(560, 399);
			this.paymentTb.MaxLength = 7;
			this.paymentTb.Name = "paymentTb";
			this.paymentTb.Size = new System.Drawing.Size(144, 35);
			this.paymentTb.TabIndex = 17;
			this.paymentTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentTbKeyPress);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(560, 371);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 25);
			this.label6.TabIndex = 19;
			this.label6.Text = "PAYMENT";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// changelbl
			// 
			this.changelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.changelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.changelbl.ForeColor = System.Drawing.Color.White;
			this.changelbl.Location = new System.Drawing.Point(721, 371);
			this.changelbl.Name = "changelbl";
			this.changelbl.Size = new System.Drawing.Size(132, 25);
			this.changelbl.TabIndex = 20;
			this.changelbl.Text = "CHANGE";
			this.changelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LabelChange
			// 
			this.LabelChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelChange.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelChange.ForeColor = System.Drawing.Color.White;
			this.LabelChange.Location = new System.Drawing.Point(710, 400);
			this.LabelChange.Name = "LabelChange";
			this.LabelChange.Size = new System.Drawing.Size(154, 33);
			this.LabelChange.TabIndex = 21;
			this.LabelChange.Text = "Total";
			this.LabelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(877, 508);
			this.Controls.Add(this.LabelChange);
			this.Controls.Add(this.changelbl);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.paymentTb);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nameeLb);
			this.Controls.Add(this.closePb);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPay);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "cafeMS";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
