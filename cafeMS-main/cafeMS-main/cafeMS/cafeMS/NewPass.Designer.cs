/*
 * Created by SharpDevelop.
 * User: Ralph
 * Date: 5/13/2023
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cafeMS
{
	partial class NewPass
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		
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
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(96, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "New Password:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(208, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 37);
			this.button2.TabIndex = 5;
			this.button2.Text = "CHANGE";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(40, 56);
			this.textBox2.MaxLength = 20;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(260, 20);
			this.textBox2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Location = new System.Drawing.Point(12, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 160);
			this.panel1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(88, 16);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 31);
			this.label4.TabIndex = 12;
			this.label4.Text = "CHANGE PASSWORD";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NewPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Indigo;
			this.ClientSize = new System.Drawing.Size(359, 228);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NewPass";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewPass";
			this.Load += new System.EventHandler(this.NewPassLoad);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewPassMouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewPassMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewPassMouseUp);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
