using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace cafeMS
{
	public partial class itemform : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
    	
		MySqlConnection cn;
		MySqlCommand cm;
		
		public itemform()
		{
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
			InitializeComponent();
		}
		void ItemformLoad(object sender, EventArgs e)
		{
			populatefood();
		}
		
		private void txtclear()
		{
			txtName.Text = "";
			txtPrice.Text = "";
			txtQty.Text = "";
		}
		
		public void populatefood()
		{
			cn.Open();
			 
		    string query = "SELECT ID, name, price, qty FROM item";
		    cm = new MySqlCommand(query, cn);
		    DataTable dt = new DataTable();
		    MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
		    adapter.Fill(dt);
		    foodDGV.DataSource = dt;
		    
		    cn.Close();
			
		}
		void FoodDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		    {
		        DataGridViewRow clickedRow = foodDGV.Rows[e.RowIndex];
		        txtName.Text = clickedRow.Cells[1].Value.ToString();
		        txtPrice.Text = clickedRow.Cells[2].Value.ToString();
		        txtQty.Text = clickedRow.Cells[3].Value.ToString();
		    }
		}
		void Label5Click(object sender, EventArgs e)
		{
			AdminSection admin = new AdminSection();
			admin.Show();
			this.Hide();
		}
		void ClosePbClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    Application.Exit();
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			AddItem additemform = new AddItem();
			additemform.ShowDialog();
		}
		void UpdateBtnClick(object sender, EventArgs e)
		{
			if (IsValidInput())
		    {
		        string selectedID = foodDGV.CurrentRow.Cells["ID"].Value.ToString();
		        string selectedName = foodDGV.CurrentRow.Cells["name"].Value.ToString();
		
		        // Check if the updated name already exists excluding the selected item
		        using (MySqlCommand cm = new MySqlCommand("SELECT COUNT(*) FROM item WHERE name = @name AND ID != @id", cn))
		        {
		            cm.Parameters.AddWithValue("@name", txtName.Text);
		            cm.Parameters.AddWithValue("@id", selectedID);
		            cn.Open();
		            int existingCount = Convert.ToInt32(cm.ExecuteScalar());
		            cn.Close();
		            if (existingCount > 0)
		            {
		                MessageBox.Show("Item with the same name already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		                return;
		            }
		        }
		
		        // Update the item
		        using (MySqlCommand cm = new MySqlCommand("UPDATE item SET name = @name, price = @price, qty = @qty WHERE ID = @id", cn))
		        {
		            cm.Parameters.AddWithValue("@name", txtName.Text);
		            cm.Parameters.AddWithValue("@price", txtPrice.Text);
		            cm.Parameters.AddWithValue("@qty", txtQty.Text);
		            cm.Parameters.AddWithValue("@id", selectedID);
		
		            cn.Open();
		            cm.ExecuteNonQuery();
		            cn.Close();
		        }
		
		        MessageBox.Show("Update successful!");
		        populatefood();
		        txtclear();
		    }
		}
		
		bool IsValidInput()
		{
		    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
		    {
		        MessageBox.Show("Please enter values for all fields.");
		        return false;
		    }
		
		    decimal price;
		    int qty;
		
		    if (!decimal.TryParse(txtPrice.Text, out price))
		    {
		        MessageBox.Show("Invalid price value.");
		        return false;
		    }
		
		    if (!int.TryParse(txtQty.Text, out qty))
		    {
		        MessageBox.Show("Invalid quantity value.");
		        return false;
		    }
		
		    return true;
		}
		void DeleteBtnClick(object sender, EventArgs e)
		{
		    if (foodDGV.SelectedRows.Count > 0)
		    {
		        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
		        
		        if (result == DialogResult.Yes)
		        {
		            string selectedID = foodDGV.SelectedRows[0].Cells["ID"].Value.ToString();
		
		            using (MySqlConnection cn = new MySqlConnection("server=localhost; user id=root; password=; database=cafems;"))
		            {
		                using (MySqlCommand cm = new MySqlCommand("DELETE FROM item WHERE ID = @id", cn))
		                {
		                    cm.Parameters.AddWithValue("@id", selectedID);
		
		                    cn.Open();
		                    cm.ExecuteNonQuery();
		                }
		            }
		            populatefood();
		
		            MessageBox.Show("Delete successful!");
		            txtclear();
		        }
		    }
		    else
		    {
		        MessageBox.Show("Please select a row to delete.");
		    }
			
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
		void TxtNameKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
		    {
		        e.Handled = true;
		    }
			
		}
		void ItemformMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void ItemformMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void ItemformMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
		void Button1Click(object sender, EventArgs e)
		{
			populatefood();
		}
	}
}
