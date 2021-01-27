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
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void FromDtPicker_ValueChanged(object sender, EventArgs e)
        {
            ToDtPicker.MinDate = Convert.ToDateTime(FromDtPicker.Value.ToString());
        }

        private void ReportsUserControl_Load(object sender, EventArgs e)
        {
            this.FromLbl.Hide();
            this.FromDtPicker.Hide();
            this.ToDtPicker.Hide();
            this.ToLbl.Hide();
            this.GoBtn.Hide();
            this.ReportDisplayView.Hide();
            this.PrintBtn.Hide();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
            con.Open();
            if(SalesRadioBtn.Checked==true)
            {
                string query = "select * from Sales where Date >= '" + this.FromDtPicker.Value.ToString("dd-MMM-yy") + "' and Date <= '" + this.ToDtPicker.Value.ToString("dd-MMM-yy") + "' order by [S.No]";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                ReportDisplayView.Show();
                ReportDisplayView.DataSource = dt;
                ReportDisplayView.ReadOnly = true;
                ReportDisplayView.Columns[1].Width = 130;
                ReportDisplayView.Columns[2].Width = 70;
                ReportDisplayView.Columns[0].Width = 25;
                ReportDisplayView.Columns[5].Visible = false;
            }
            else if(SalesReturnsRadioBtn.Checked==true)
            {
                string query = "SELECT * from SalesReturns where Date >= '" + this.FromDtPicker.Value.ToString("dd-MMM-yy") + "' and Date <= '" + this.ToDtPicker.Value.ToString("dd-MMM-yy") + "' order by [S.No]";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                ReportDisplayView.Show();
                ReportDisplayView.DataSource = dt;
                ReportDisplayView.Columns[0].Width = 25;
                ReportDisplayView.Columns[2].Width = 130;
                ReportDisplayView.Columns[5].Visible = false;
                ReportDisplayView.ReadOnly = true;
            }
            con.Close();
            PrintBtn.Show();
        }

        private void FromDtPicker_Enter(object sender, EventArgs e)
        {
            FromDtPicker.MaxDate = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void ToDtPicker_Enter(object sender, EventArgs e)
        {
            ToDtPicker.MaxDate = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void SalesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(SalesRadioBtn.Checked==true)
            {
                SalesReturnsRadioBtn.Checked = false;
                this.FromLbl.Show();
                this.FromDtPicker.Show();
                this.ToLbl.Show();
                this.ToDtPicker.Show();
                this.GoBtn.Show();
            }
        }

        private void SalesReturnsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(SalesReturnsRadioBtn.Checked==true)
            {
                SalesRadioBtn.Checked = false;
                this.FromLbl.Show();
                this.FromDtPicker.Show();
                this.ToLbl.Show();
                this.ToDtPicker.Show();
                this.GoBtn.Show();
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            if(SalesRadioBtn.Checked==true)
            {
                printer.Title = "Sales Report";
                printer.SubTitle = "Generated on '" +DateTime.Now+ "' ";
            }
            else if(SalesReturnsRadioBtn.Checked==true)
            {
                printer.Title = "Sales Returns Report";
                printer.SubTitle = "Generated on '" +DateTime.Now+ "' ";
            }
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mahipal Textiles";
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(ReportDisplayView);
        }
    }
}
