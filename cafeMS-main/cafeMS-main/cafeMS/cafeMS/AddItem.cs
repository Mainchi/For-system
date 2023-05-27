using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace cafeMS
{
	public partial class AddItem : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
    	
		MySqlConnection cn;
		MySqlCommand cm;
		public AddItem()
		{
			InitializeComponent();
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Image files (*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif";
		    DialogResult result = openFileDialog1.ShowDialog();
		    if (result == DialogResult.OK)
		    {
		        try
		        {
		            pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
		        }
		        catch (Exception ex)
		        {
		            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		        }
		    }
		}
		void Button2Click(object sender, EventArgs e)
		{
			if (pictureBox1.BackgroundImage == null || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
		    {
		        MessageBox.Show("Missing Required Information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		        return;
		    }
		
			    try
			    {
			        using (MemoryStream ms = new MemoryStream())
			        {
			            pictureBox1.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
			            byte[] arrImage = ms.ToArray();
			
			            using (cn = new MySqlConnection("server=localhost; user id=root;password=; database=cafems;"))
			            {
			                cn.Open();
			                // Check if the item name already exists
			                using (cm = new MySqlCommand("SELECT COUNT(*) FROM item WHERE name = @name", cn))
			                {
			                    cm.Parameters.AddWithValue("@name", txtName.Text);
			                    int existingCount = Convert.ToInt32(cm.ExecuteScalar());
			                    if (existingCount > 0)
			                    {
			                        MessageBox.Show("Item with the same name already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			                        return;
			                    }
			                }
			
			                // Insert the new item
			                using (cm = new MySqlCommand("INSERT INTO item (name, price, qty, image) VALUES (@name, @price, @qty, @image)", cn))
			                {
			                    cm.Parameters.AddWithValue("@name", txtName.Text);
			                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
			                    cm.Parameters.AddWithValue("@qty", txtQty.Text);
			                    cm.Parameters.AddWithValue("@image", arrImage);
			                    cm.ExecuteNonQuery();
			                }
			                MessageBox.Show("Item Saved");
			
			                // Clear inputted text and images
			                txtName.Text = string.Empty;
			                txtPrice.Text = string.Empty;
			                txtQty.Text = string.Empty;
			                pictureBox1.BackgroundImage = null;
			
			                // Close the form
			                this.Close();
			            }
			        }
			    }
			    catch (Exception ex)
			    {
			        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    }
			
		}
		void ClosePbClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void TxtPriceKeyPress(object sender, KeyPressEventArgs e)
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
		void TxtQtyKeyPress(object sender, KeyPressEventArgs e)
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
		void AddItemMouseMove(object sender, MouseEventArgs e)
		{
			
		}
		void AddItemMouseUp(object sender, MouseEventArgs e)
		{
			
		}
		void AddItemMouseDown(object sender, MouseEventArgs e)
		{
			
		}
		void TxtNameKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
		    {
		        e.Handled = true;
		    }
			
		}
		void TxtQtyTextChanged(object sender, EventArgs e)
		{
	
		}
		void Panel1MouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void Panel1MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
	}
}
