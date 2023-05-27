
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace cafeMS
{
	public partial class AdminSection : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
		
		MySqlConnection cn;
		
		
		public AdminSection()
		{
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
			InitializeComponent();
		
		}
		void AdminSectionLoad(object sender, EventArgs e)
		{
	
		}
		void ClosePbClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    Application.Exit();
			}
		}
		void LogoutPbClick(object sender, EventArgs e)
		{
			LoginForm lform = new LoginForm();
			if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
			    lform.Show();
			    this.Hide();
			}
		}
		void AddItemPbClick(object sender, EventArgs e)
		{
			itemform iform = new itemform();
			iform.Show();
			this.Hide();
		}
		void HistoryPbClick(object sender, EventArgs e)
		{
			historyform history = new historyform();
			history.Show();
			this.Hide();
		}
		void AdminsPbClick(object sender, EventArgs e)
		{
			admins adminform = new admins();
			adminform.Show();
			this.Hide();
		}
		void AddAdminPbClick(object sender, EventArgs e)
		{
			RegisterAdmin adminform = new RegisterAdmin();
			adminform.ShowDialog();
		}
		void UsersPbClick(object sender, EventArgs e)
		{
			users userform = new users();
			userform.Show();
			this.Hide();
		}
		void AdminSectionMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void AdminSectionMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
			
		}
		void AdminSectionMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
		
	}
}
