using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Linq;

namespace cafeMS
{
	public partial class Fpass : Form
	{
		private Point mouseOffset;
    	private bool isMouseDown = false;
		
        MySqlConnection cn;
		MySqlCommand cm;
		int code = new Random().Next(100000, 999999);
		public static string to;
		public Fpass()
		{
			cn = new MySqlConnection();
			cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
			InitializeComponent();
		}
		
		public string EmailValue { get; private set; }


		void UsernameTbLeave(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			to = emailTb.Text;
	        string message = "Your OTP is: " + code;
	            
			cm = new MySqlCommand("SELECT * FROM user  WHERE Email=@emails", cn);
			cm = new MySqlCommand("SELECT * FROM admin  WHERE email=@emails", cn);
		    cm.Parameters.AddWithValue("@emails", emailTb.Text);
		
		    MySqlDataAdapter da = new MySqlDataAdapter(cm);
		    DataTable dt = new DataTable();
		    da.Fill(dt);
		
		    if (dt.Rows.Count > 0)
		    {
	            try
	            {
	                MailMessage mail = new MailMessage();
	                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
	
	                mail.From = new MailAddress("cafeleng.01@gmail.com");
	                mail.To.Add(to);
	                mail.Subject = "OTP Verification";
	                mail.Body = message;
	
	                SmtpServer.Port = 587;
	                SmtpServer.Credentials = new System.Net.NetworkCredential("cafeleng.01@gmail.com", "ejtcgunjjkgrwetp");
	                SmtpServer.EnableSsl = true;
	
	                SmtpServer.Send(mail);
	                MessageBox.Show("An OTP has been sent to " + to +". Please enter the code in the verification box.");
	            }
	            catch (Exception ex)
	            {
	                MessageBox.Show("Error sending email: " + ex.Message);
	            }
		    }
		    else
		    {
		        MessageBox.Show("Invalid email");
		    }
		    
	    }
		
		void Button2Click(object sender, EventArgs e)
		{
			LoginForm form = new LoginForm();
			form.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (textBox1.Text == code.ToString())
		    {
		        EmailValue = emailTb.Text;
		        NewPass passform = new NewPass();
		        passform.Show();
		        this.Hide();
		    }
		    else
		    {
		        MessageBox.Show("OTP is not Acceptable, please explain");
		    }
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void FpassMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
	        {
	            Point mousePos = Control.MousePosition;
	            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
	            Location = mousePos;
	        }
		}
		void FpassMouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            isMouseDown = false;
	        }
		}
		void FpassMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
	        {
	            mouseOffset = new Point(-e.X, -e.Y);
	            isMouseDown = true;
	        }
		}
		
		
		}
	}
