using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Amazon_Accounts
{
    public partial class CancelledOrderUserControl : UserControl
    {
        public CancelledOrderUserControl()
        {
            InitializeComponent();
        }
        string orderId, invoiceNo, Date;
        private void CancelledOrderUserControl_Load(object sender, EventArgs e)
        {
            this.ActiveControl = OrderIdTxt;
            this.FromLbl.Hide();
            this.FromDtPicker.Hide();
            this.ToLbl.Hide();
            this.ToDtPicker.Hide();
            this.GoBtn.Hide();
            this.CancelledOrderView.Hide();
        }

        private void OrderIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 45)
                e.Handled = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (OrderIdTxt.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
                    con.Open();
                    string query = "select * from Sales where OrderId = '" + this.OrderIdTxt.Text + "' ";
                    SqlDataAdapter DA = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    DA.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        SalesDetailsView.DataSource = dt;
                        orderId = Convert.ToString(dt.Rows[0][1]);
                        invoiceNo = Convert.ToString(dt.Rows[0][2]);
                        Date = Convert.ToString(dt.Rows[0][3]);
                    }
                    else
                    {
                        MessageBox.Show("The order ID was either entered wrong or not found", "Cancelled Order Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderIdTxt.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    OrderIdTxt.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter the Order ID", "Cancelled Order Page");
                OrderIdTxt.Focus();
                OrderIdTxt.Text = "";
            }
        }

        private void ShowReportBtn_Click(object sender, EventArgs e)
        {
            this.FromLbl.Show();
            this.FromDtPicker.Show();
            this.ToLbl.Show();
            this.ToDtPicker.Show();
            this.GoBtn.Show();
        }

        private void FromDtPicker_ValueChanged(object sender, EventArgs e)
        {
            ToDtPicker.MinDate = Convert.ToDateTime(FromDtPicker.Value.ToString());
        }

        private void FromDtPicker_Enter(object sender, EventArgs e)
        {
            FromDtPicker.MaxDate = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void ToDtPicker_Enter(object sender, EventArgs e)
        {
            ToDtPicker.MaxDate = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Cancelled Orders Report Report";
            printer.SubTitle = "This report was generated as per your request";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mahipal Textiles";
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(CancelledOrderView);
        }

        private void CancelOrderBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
            con.Open();
            string query = "Insert into CancelledOrders (Date, OrderId, InvoiceNo) values ('"+Convert.ToDateTime(Date)+ "', '" + orderId + "', '" + invoiceNo + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            string query1 = "DELETE FROM Sales where OrderId = '" +this.OrderIdTxt.Text+ "' ";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The order has been cancelled successfully", "Cancelled orders Page");
            con.Close();
            this.OrderIdTxt.Text = "";
            this.SalesDetailsView.DataSource = "";
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
            con.Open();
            string query = "select * from CancelledOrders where Date >= '" + Convert.ToDateTime(this.FromDtPicker.Value.ToString("dd-MM-yyyy")) + "' and Date <= '" + Convert.ToDateTime(this.ToDtPicker.Value.ToString("dd-MM-yyyy")) + "' ";
            SqlDataAdapter DA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No records found", "Cancelled Orders Page");
                CancelledOrderView.DataSource = "";
            }
            else
            {
                CancelledOrderView.Show();
                CancelledOrderView.DataSource = dt;
                CancelledOrderView.Enabled = false;
                PrintBtn.Show();
            }
        }
    }
}

