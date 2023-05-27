using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cafeMS
{
    public partial class LoginForm : Form
    {
    	private Point mouseOffset;
    	private bool isMouseDown = false;
    	
        private readonly MySqlConnection cn;
        private readonly MySqlCommand cm;

        public LoginForm()
        {
            InitializeComponent();

            cn = new MySqlConnection("server=localhost; user id=root;password=; database=cafems;");
            cm = new MySqlCommand("", cn);
        }

        private void Button1Click(object sender, EventArgs e)
        {
        	if (string.IsNullOrEmpty(usernameTB.Text) || string.IsNullOrEmpty(passwordTb.Text))
		    {
		        MessageBox.Show("Please enter a username and password.");
		        return;
		    }
		
		    try
		    {
		        using (MySqlConnection cn = new MySqlConnection("server=localhost; user id=root; password=; database=cafems;"))
		        {
		            cn.Open();
		
		            using (MySqlCommand cm = new MySqlCommand())
		            {
		                cm.Connection = cn;
		                cm.CommandText = "SELECT name FROM user WHERE username=@uname AND password=@upass";
		                cm.Parameters.AddWithValue("@uname", usernameTB.Text);
		                cm.Parameters.AddWithValue("@upass", passwordTb.Text);
		
		                using (MySqlDataReader dr = cm.ExecuteReader())
		                {
		                    if (dr.HasRows)
		                    {
		                        while (dr.Read()) // Iterate over the result rows
		                        {
		                            string namee = dr["name"].ToString();
		                            MessageBox.Show("Login Successful.");
		                            this.Hide();
		
		                            MainForm mainForm = new MainForm(namee);
		                            mainForm.Show();
		                        }
		                    }
		                    else
		                    {
		                        dr.Close();
		
		                        cm.CommandText = "SELECT * FROM admin WHERE username=@uname AND password=@upass";
		
		                        using (MySqlDataReader dr2 = cm.ExecuteReader())
		                        {
		                            if (dr2.HasRows)
		                            {
		                                MessageBox.Show("Login Successful.");
		                                this.Hide();
		
		                                AdminSection adminSection = new AdminSection();
		                                adminSection.Show();
		                            }
		                            else
		                            {
		                                MessageBox.Show("Incorrect username or password.");
		                            }
		                        }
		                    }
		                }
		            }
		        }
		    }
		    catch (MySqlException ex)
		    {
		        MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
		    }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    Application.Exit();
			}
        }

        private void Label6Click(object sender, EventArgs e)
        {
            RegisterUser rUser = new RegisterUser();
            rUser.Show();
            this.Hide();
        }

        private void Panel2Paint(object sender, PaintEventArgs e)
        {

        }
		
        private void Label3Click(object sender, EventArgs e)
        {
            Fpass fform = new Fpass();
            fform.Show();
            this.Hide();
        }

        private void Label4Click(object sender, EventArgs e)
        {
	
        }
		void LoginFormMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void LoginFormMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void LoginFormMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
    }
}
