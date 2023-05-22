using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Printing;


namespace cafeMS
{
    public partial class historyform : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        MySqlConnection cn;
        MySqlCommand cm;
        DataTable dt;

        public historyform()
        {
            cn = new MySqlConnection();
            cn.ConnectionString = "server=localhost; user id=root;password=; database=cafems;";
            InitializeComponent();

            dt = new DataTable();
            historyDGV.DataSource = dt;

            sortTb.TextChanged += SortTbTextChanged;
            historyDGV.CellDoubleClick += HistoryDGVCellDoubleClick;
        }

        void ClosePbClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Close Application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void populatehistory()
        {
            cn.Open();

            string query = "SELECT ID, name, date, items, qty, total FROM history";
            cm = new MySqlCommand(query, cn);
            dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
            adapter.Fill(dt);
            historyDGV.DataSource = dt;

            cn.Close();
        }

        void HistoryformLoad(object sender, EventArgs e)
        {
            populatehistory();
        }

        void SortTbTextChanged(object sender, EventArgs e)
        {
            string searchText = sortTb.Text.Trim();

            if (searchText == string.Empty)
            {
                historyDGV.DataSource = dt;
            }
            else
            {
                DataView dataView = dt.DefaultView;
                dataView.RowFilter = "name LIKE '%" + searchText + "%' OR " +
                                     "CONVERT(ID, 'System.String') LIKE '%" + searchText + "%' OR " +
                                     "date LIKE '%" + searchText + "%' OR " +
                                     "CONVERT(total, 'System.String') LIKE '%" + searchText + "%' OR " +
                                     "items LIKE '%" + searchText + "%'";
                historyDGV.DataSource = dataView.ToTable();
            }
        }

        void Label5Click(object sender, EventArgs e)
        {
            AdminSection adminform = new AdminSection();
            adminform.Show();
            this.Hide();
        }

        void HistoryformMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        void HistoryformMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        void HistoryformMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        void HistoryDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void HistoryDGVCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = historyDGV.Rows[e.RowIndex];
                string name = selectedRow.Cells["name"].Value.ToString();
                string date = selectedRow.Cells["date"].Value.ToString();
                string items = selectedRow.Cells["items"].Value.ToString();
                string qty = selectedRow.Cells["qty"].Value.ToString();
                string total = selectedRow.Cells["total"].Value.ToString();

                PrintData1(name, date, items, qty, total);
            }
        }

        void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (printData != null)
		    {
		        // Define the font, brush, and coordinates for printing
		        Font font = new Font("Arial", 12);
		        SolidBrush brush = new SolidBrush(Color.Black);
		        int startX = 10;
		        int startY = 40;
		        int offset = 30;
		
		        // Print the data on the page
		        e.Graphics.DrawString("Order Receipt", font, brush, 250, 10);
		        
		        e.Graphics.DrawString("Name: " + printData.Name, font, brush, startX, startY);
		        e.Graphics.DrawString("Date: " + printData.Date, font, brush, startX, startY + offset);
		        e.Graphics.DrawString("Items: " + printData.Items, font, brush, startX, startY + 2 * offset);
		        e.Graphics.DrawString("QTY: " + printData.Qty, font, brush, startX, startY + 3 * offset);
		        e.Graphics.DrawString("Total: " + printData.Total, font, brush, startX, startY + 4 * offset);
		    }
        }

        private PrintData printData;

        private void PrintData1(string name, string date, string items, string qty, string total)
        {
        	printData = new PrintData(name, date, items, qty, total);

		    PrintDocument pd = new PrintDocument();
		    pd.PrintPage += new PrintPageEventHandler(PrintDocument1PrintPage);
		
		    PrintPreviewDialog printDialog = new PrintPreviewDialog();
		    printDialog.Document = pd;
		    if (printDialog.ShowDialog() == DialogResult.OK)
		    {
		        pd.Print();
		    }
        }

        private class PrintData
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Items { get; set; }
            public string Qty { get; set; }
            public string Total { get; set; }

            public PrintData(string name, string date, string items, string qty, string total)
            {
                Name = name;
                Date = date;
                Items = items;
                Qty = qty;
                Total = total;
            }
        }
    }
}
