using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using System.Drawing.Printing;

namespace cafeMS
{

	public partial class MainForm : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
		
		MySqlConnection cn;
		MySqlCommand cm;
		MySqlDataReader dr;
		public MainForm(string namee)
		{
			InitializeComponent();
			paymentTb.TextChanged += PaymentTbTextChanged;
			nameeLb.Text = namee;
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
			dataGridView1.Columns.Add("No", "No");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Qty", "Qty");
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 2, 67);
		    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
		    dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
		    dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            
            dataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(OnCellDoubleClick);
		}
		
		private void UpdateTotal(decimal TotalAmount)
		{
			decimal subtotal = 0;
            decimal total = 0;
            	
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                double price = double.Parse(row.Cells["Price"].Value.ToString().Replace(",", ""));
                int quantity = int.Parse(row.Cells["Qty"].Value.ToString());
                subtotal += (decimal)price * quantity;
            }

            
            total = subtotal;
            label1.Text = total.ToString("#,###,##0.00");
		}

		private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		    if (e.RowIndex >= 0)
			{
			    if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			    {
			        double price = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString().Replace(",", ""));
			        int quantity = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Qty"].Value.ToString());
			        double subtotal = price * quantity;
			        dataGridView1.Rows.RemoveAt(e.RowIndex);
			        decimal newTotal = (decimal)(-subtotal);
			        UpdateTotal(newTotal);
			    }
			}
		}
		
		private PictureBox pic;
		private Label price;
		private Label name;
		void MainFormLoad(object sender, EventArgs e)
		{
            GetData();
            dateLabel.Text = DateTime.Now.ToString();
		}
		
		private void GetData()
		{
			cn.Open();
			
			cm = new MySqlCommand("SELECT image, ID, name, price from item", cn);
			dr = cm.ExecuteReader();
			while(dr.Read())
			{
				long len = dr.GetBytes(0,0, null, 0,0);
				byte[] array = new byte[Convert.ToInt32(len) + 1];
				dr.GetBytes(0,0, array, 0, Convert.ToInt32(len));
				pic = new PictureBox();
				pic.Width = 100;
				pic.Height = 150;
				pic.BackgroundImageLayout = ImageLayout.Zoom;
				pic.BorderStyle = BorderStyle.FixedSingle;
				pic.Tag = dr["ID"].ToString();
				pic.Cursor = Cursors.Hand;
				
				price = new Label();
				price.Text = "₱ " + dr["price"].ToString();
				price.BackColor = Color.FromArgb(17, 0, 45);
				price.ForeColor = Color.FromArgb(255, 255, 255);
				price.TextAlign = ContentAlignment.MiddleCenter;
				price.Dock = DockStyle.Top;
				price.Font = new Font("Sequi UI", 12);
				
				
				
				name = new Label();
				name.Text = dr["name"].ToString();
				name.BackColor = Color.FromArgb(17, 0, 45);
				name.ForeColor = Color.FromArgb(255, 255, 255);
				name.TextAlign = ContentAlignment.MiddleCenter;
				name.Dock = DockStyle.Bottom;
				name.Font = new Font("Sequi UI", 9);
				
				
				MemoryStream ms = new MemoryStream(array);
				Bitmap bitmap = new Bitmap(ms);
				pic.BackgroundImage = bitmap;
				
				pic.Controls.Add(name);
				pic.Controls.Add(price);
				flowLayoutPanel1.Controls.Add(pic);
				
				pic.Click += new EventHandler(OnClick);
				
			}
			
			dr.Close();
			cn.Close();
		}
		
		public void OnClick(object sender, EventArgs e)
		{
			if (sender is PictureBox)
		    {
		        string tag = (sender as PictureBox).Tag.ToString();
		
		        cn.Open();
		        cm = new MySqlCommand("SELECT * FROM item WHERE ID LIKE @tag", cn);
		        cm.Parameters.AddWithValue("@tag", tag);
		        dr = cm.ExecuteReader();
		        dr.Read();
		        if (dr.HasRows)
		        {
		            int quantity = int.Parse(dr["qty"].ToString());
		            if (quantity > 0)
		            {
		                bool itemExists = false;
		                foreach (DataGridViewRow row in dataGridView1.Rows)
		                {
		                    if (row.Cells["ID"].Value.ToString() == dr["ID"].ToString())
		                    {
		                        int rowQuantity = int.Parse(row.Cells["Qty"].Value.ToString());
		                        if (rowQuantity < quantity) // Check if quantity is less than available stock
		                        {
		                            rowQuantity++;
		                            row.Cells["Qty"].Value = rowQuantity;
		                            itemExists = true;
		                            break;
		                        }
		                        else
		                        {
		                            MessageBox.Show("The item quantity exceeds the available stock.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Information);
		                            itemExists = true;
		                            break;
		                        }
		                    }
		                }
		
		                if (!itemExists)
		                {
		                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["ID"].ToString(), dr["name"].ToString(), double.Parse(dr["price"].ToString()).ToString("#,###,00"), 1);
		                }
		
		                decimal subtotal = CalculateTotal();
		                UpdateTotal(subtotal);
		            }
		            else
		            {
		                MessageBox.Show("The item is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
		            }
		        }
		
		        cn.Close();
		    }
			
		}
		
		private decimal CalculateTotal()
		{
		    decimal total = 0;
		    foreach (DataGridViewRow row in dataGridView1.Rows)
		    {
		        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
		        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
		        total += quantity * price;
		    }
		    return total;
		}
		
		void BtnPayClick(object sender, EventArgs e)
		{
			decimal total = CalculateTotal();
		    decimal payamount = 0;
		
		    if (!decimal.TryParse(paymentTb.Text, out payamount))
		    {
		        MessageBox.Show("Invalid payment amount. Please enter a valid numeric value.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
		        return;
		    }
		
		    if (payamount < total)
		    {
		        MessageBox.Show("Payment amount is lower than the total. Please enter a sufficient payment amount.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
		        return;
		    }
	    foreach (DataGridViewRow row in dataGridView1.Rows)
	    {
	        int qty = Convert.ToInt32(row.Cells["Qty"].Value);
	        string item_name = row.Cells["Name"].Value.ToString();
	        cn.Open();
	        {
	        	cm = new MySqlCommand("UPDATE item SET qty = qty - @qty WHERE name = @name", cn);
	            cm.Parameters.AddWithValue("@qty", qty);
	            cm.Parameters.AddWithValue("@name", item_name);
	            cm.ExecuteNonQuery();
	        }
	        cn.Close();
	    }
	    
	    {
				string items = "";
                string quan = "";
                string price = "";
                long orderID = cm.LastInsertedId;
                int payment = int.Parse(paymentTb.Text);
                double change = Double.Parse(LabelChange.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    items += row.Cells["Name"].Value.ToString() + Environment.NewLine;
                    quan += row.Cells["Qty"].Value.ToString() + Environment.NewLine;
                    price += row.Cells["Price"].Value.ToString() + Environment.NewLine;

                }
                items = items.TrimEnd(',');
                cn.Open();
                cm = new MySqlCommand("INSERT INTO history (name, itemID, date, qty, price, total, items, payment, Pchange) VALUES (@name, @order_id, @date, @quantity, @price, @total, @items, @payment, @change)", cn);
                cm.Parameters.AddWithValue("@name", nameeLb.Text);
                cm.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                cm.Parameters.AddWithValue("@total", label1.Text.Replace(",", " "));
                cm.Parameters.AddWithValue("@items", items);
                cm.Parameters.AddWithValue("@order_id", orderID);
                cm.Parameters.AddWithValue("@quantity", quan);
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@payment", payment);
                cm.Parameters.AddWithValue("@change", change);
                cm.ExecuteNonQuery();
                cn.Close();
	    }
		    PrintDocument pd = new PrintDocument();
		
		    pd.DocumentName = "Order Receipt";

		    pd.PrintPage += new PrintPageEventHandler(PrintDocument1PrintPage);
		
		    PrintPreviewDialog printDialog = new PrintPreviewDialog();
		    printDialog.Document = pd;
		    if (printDialog.ShowDialog() == DialogResult.OK)
		    {
		        pd.Print();
		    }
		    dataGridView1.Rows.Clear();
		    label1.Text = "0.00";
		    LabelChange.Text = "0.00";
		    paymentTb.Text = "";
		    }
		void PrintDocument1PrintPage(object sender, PrintPageEventArgs e)
			{
			    Font font = new Font("Arial", 12, FontStyle.Bold);
			    Brush brush = new SolidBrush(Color.Black);
			
			    float x = 50, y = 50;
			
			    StringFormat centerAlign = new StringFormat();
			    centerAlign.Alignment = StringAlignment.Center;
			    
			    StringFormat leftAlign = new StringFormat();
			    leftAlign.Alignment = StringAlignment.Near;
			    
			    StringFormat rightAlign = new StringFormat();
			    rightAlign.Alignment = StringAlignment.Far;
			    
			    e.Graphics.DrawString("Account : " +nameeLb.Text+ "", font, brush, e.PageBounds.Width / 20, 20);
			    e.Graphics.DrawString("Order Receipt", font, brush, e.PageBounds.Width / 2, y, centerAlign);
			    e.Graphics.DrawString("CAFE NATEN", font, brush, e.PageBounds.Width / 2, 20, centerAlign);
			    e.Graphics.DrawString("Date :" +dateLabel.Text+ "", font, brush, e.PageBounds.Width / 20, y);
			    y += 40;
			
			    e.Graphics.DrawString("Item", font, brush, x, y);
			    e.Graphics.DrawString("Quantity", font, brush, x + 200, y);
			    e.Graphics.DrawString("Price", font, brush, x + 400, y);
			    y += 20;
			
			    e.Graphics.DrawLine(new Pen(Color.Black), x, y, e.PageBounds.Width - x, y);
			    y += 10;
			
			    foreach (DataGridViewRow row in dataGridView1.Rows)
			    {
			        string item = row.Cells["Name"].Value.ToString();
			        int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
			        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
			
			        e.Graphics.DrawString(item, font, brush, x, y);
			        e.Graphics.DrawString(quantity.ToString(), font, brush, x + 200, y);
			        e.Graphics.DrawString(price.ToString(), font, brush, x + 400, y);
			        y += 30;
			    }
			
			    e.Graphics.DrawLine(new Pen(Color.Black), x, y, e.PageBounds.Width - x, y);
			    y += 20;
			
			    decimal total = CalculateTotal();
			    e.Graphics.DrawString("Total:", font, brush, x + 200, 300);
			    e.Graphics.DrawString("Payment:", font, brush, x + 200, 350);
			    e.Graphics.DrawString("Change:", font, brush, x + 200, 400);
			    e.Graphics.DrawString(total.ToString(), font, brush, x + 400, 300);
			    e.Graphics.DrawString(paymentTb.Text, font, brush, x + 400, 350);
			    e.Graphics.DrawString(LabelChange.Text, font, brush, x + 400, 400);
			}
		void Label3Click(object sender, EventArgs e)
		{
			LoginForm lform = new LoginForm();
			if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    lform.Show();
			    this.Hide();
			}
		}
		void ClosePbClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    Application.Exit();
			}
		}
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
		void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void MainFormMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void PaymentTbTextChanged(object sender, EventArgs e)
		{
			decimal total = CalculateTotal();
		    decimal payment = 0;
		
		    if (decimal.TryParse(paymentTb.Text, out payment))
		    {
		        decimal change = payment - total;
		         LabelChange.Text = change.ToString("#,###,##0.00");
		    }
		    else
		    {
		        LabelChange.Text = string.Empty;
		    }
			
		}
		void PaymentTbKeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
			
			if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > - 1))
			{
				e.Handled = true;
			}
		}
		    
	}
		
}
