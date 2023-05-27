using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace cafeMS
{
	public partial class users : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
    	
		MySqlConnection cn;
		MySqlCommand cm;
		public users()
		{
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
			InitializeComponent();
		}
		private void txtclear()
		{
			txtName.Text = "";
			txtUser.Text = "";
			txtPass.Text = "";
		}
		
		private void populateuser()
		{
			cn.Open();
			 
		    string query = "SELECT ID, name, username, password, email FROM user";
		    cm = new MySqlCommand(query, cn);
		    DataTable dt = new DataTable();
		    MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
		    adapter.Fill(dt);
		    userDGV.DataSource = dt;
		    
		    cn.Close();
		}
		void UsersLoad(object sender, EventArgs e)
		{
			populateuser();
		}
		void UserDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
		    {
		        DataGridViewRow clickedRow = userDGV.Rows[e.RowIndex];
		        txtName.Text = clickedRow.Cells[1].Value.ToString();
		        txtUser.Text = clickedRow.Cells[2].Value.ToString();
		        txtPass.Text = clickedRow.Cells[3].Value.ToString();
		    }
			
		}
		bool IsValidInput()
		{
		    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
		    {
		        MessageBox.Show("Please enter values for all fields.");
		        return false;
		    }
		    return true;
		}
		void UpdateBtnClick(object sender, EventArgs e)
		{
			if (IsValidInput())
		    {
		        if (userDGV.SelectedRows.Count > 0)
		        {
		            DialogResult result = MessageBox.Show("Are you sure you want to update this row?", "Confirmation", MessageBoxButtons.YesNo);
		
		            if (result == DialogResult.Yes)
		            {
		                string selectedID = userDGV.SelectedRows[0].Cells["ID"].Value.ToString();
		
		                try
		                {
		                    using (MySqlConnection cn = new MySqlConnection("server=localhost; user id=root; password=; database=cafems;"))
		                    {
		                        cn.Open();
		
		                        // Check if the name, username, and password already exist in the database
		                        string query = "SELECT COUNT(*) FROM user WHERE (name = @name OR username = @user) AND ID != @id";
		                        using (MySqlCommand checkCommand = new MySqlCommand(query, cn))
		                        {
		                            checkCommand.Parameters.AddWithValue("@name", txtName.Text);
		                            checkCommand.Parameters.AddWithValue("@user", txtUser.Text);
		                            checkCommand.Parameters.AddWithValue("@id", selectedID);
		
		                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
		                            if (count > 0)
		                            {
		                                MessageBox.Show("Name or Username already exists. Please choose different values.");
		                                txtclear();
		                                return;
		                            }
		                        }
		
		                        // If no duplicates found, update the user
		                        using (MySqlCommand cm = new MySqlCommand("UPDATE user SET name = @name, username = @user, password = @pass WHERE ID = @id", cn))
		                        {
		                            cm.Parameters.AddWithValue("@name", txtName.Text);
		                            cm.Parameters.AddWithValue("@user", txtUser.Text);
		                            cm.Parameters.AddWithValue("@pass", txtPass.Text);
		                            cm.Parameters.AddWithValue("@id", selectedID);
		                            cm.ExecuteNonQuery();
		                        }
		
		                        MessageBox.Show("Update successful!");
		                        populateuser();
		                        txtclear();
		                    }
		                }
		                catch (Exception ex)
		                {
		                    MessageBox.Show("Error: " + ex.Message);
		                }
		            }
		        }
		        else
		        {
		            MessageBox.Show("Please select a row to update.");
		        }
		    }
		}
		void DeleteBtnClick(object sender, EventArgs e)
		{
			if (userDGV.SelectedRows.Count > 0)
		    {
		        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo);
		
		        if (result == DialogResult.Yes)
		        {
		            string selectedID = userDGV.SelectedRows[0].Cells["ID"].Value.ToString();
		
		            try
		            {
		                cn.Open();
		
		                using (MySqlCommand cm = new MySqlCommand("DELETE FROM user WHERE ID = @id", cn))
		                {
		                    cm.Parameters.AddWithValue("@id", selectedID);
		                    cm.ExecuteNonQuery();
		                }
		
		                populateuser();
		
		                MessageBox.Show("Delete successful!");
		            }
		            catch (Exception ex)
		            {
		                MessageBox.Show("Error: " + ex.Message);
		            }
		            finally
		            {
		                cn.Close();
		            }
		        }
		    }
		    else
		    {
		        MessageBox.Show("Please select a row to delete.");
		    }
		}
		void Label5Click(object sender, EventArgs e)
		{
			AdminSection adminsec = new AdminSection();
			adminsec.Show();
			this.Hide();
		}
		void ClosePbClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    Application.Exit();
			}
		}
		void UsersMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void UsersMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void UsersMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
	}
}
