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
    public partial class PaymentsUserControl : UserControl
    {
        public PaymentsUserControl()
        {
            InitializeComponent();
        }

        private void PaymentsUserControl_Load(object sender, EventArgs e)
        {
            this.ActiveControl = DateTxt;
            this.FromLbl.Hide();
            this.FromDtPicker.Hide();
            this.ToLbl.Hide();
            this.ToDtPicker.Hide();
            this.GoBtn.Hide();
            this.PaymentsDetailsView.Hide();
            this.PrintBtn.Hide();
        }

        private void CODRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CODRadioBtn.Checked == true)
                ElectronicRadioBtn.Checked = false;
        }

        private void ElectronicRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ElectronicRadioBtn.Checked == true)
                CODRadioBtn.Checked = false;
        }

        private void FromDtPicker_Enter(object sender, EventArgs e)
        {
            FromDtPicker.MaxDate = DateTime.Now;
        }

        private void ToDtPicker_MouseEnter(object sender, EventArgs e)
        {
            ToDtPicker.MaxDate = DateTime.Now;
        }

        private void FromDtPicker_ValueChanged(object sender, EventArgs e)
        {
            ToDtPicker.MinDate = Convert.ToDateTime(FromDtPicker.Value.ToShortDateString());
        }

        private void EnterDataBtn_Click(object sender, EventArgs e)
        {
            if(DateTxt.Text!="" && AmtText.Text!="" && (CODRadioBtn.Checked==true || ElectronicRadioBtn.Checked==true))
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
                con.Open();
                string date = Convert.ToDateTime(DateTxt.Text).ToString("dd-MM-yyyy");
                if (CODRadioBtn.Checked == true)
                {
                    string query = "INSERT INTO Payments (Date, Amount, Type) VALUES ('" + Convert.ToDateTime(date) + "', '" + Convert.ToDouble(this.AmtText.Text) + "', '" + Convert.ToString("COD") + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully", "Payments Page");
                    con.Close();
                    DateTxt.Text = "";
                    AmtText.Text = "";
                }
                else if (ElectronicRadioBtn.Checked == true)
                {
                    string query = "INSERT INTO Payments (Date, Amount, Type) VALUES ('" + Convert.ToDateTime(date) + "', '" + Convert.ToDouble(this.AmtText.Text) + "', '" + Convert.ToString("Electronic") + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully", "Payments Page");
                    con.Close();
                    DateTxt.Text = "";
                    AmtText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Enter all the required details", "Payments Page");
                DateTxt.Focus();
            }
        }

        private void ShowReportBtn_Click(object sender, EventArgs e)
        {
            this.FromDtPicker.Show();
            this.FromLbl.Show();
            this.ToLbl.Show();
            this.ToDtPicker.Show();
            this.GoBtn.Show();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
            con.Open();
            string query = "select * from Payments where Date >= '" + this.FromDtPicker.Value.ToString("dd-MMM-yy") + "' and Date <= '" + this.ToDtPicker.Value.ToString("dd-MMM-yy") + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            this.PaymentsDetailsView.Show();
            PaymentsDetailsView.DataSource = dt;
            PaymentsDetailsView.ReadOnly = true;
            this.PrintBtn.Show();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Payments Report";
            printer.SubTitle = "Generated on '" + DateTime.Now + "' ";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mahipal Textiles";
            printer.FooterSpacing = 20;
            printer.PrintDataGridView(PaymentsDetailsView);
        }
    }
}
