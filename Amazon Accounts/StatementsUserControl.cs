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

namespace Amazon_Accounts
{
    public partial class StatementsUserControl : UserControl
    {
        public StatementsUserControl()
        {
            InitializeComponent();
        }

        private void FromDtPicker_Enter(object sender, EventArgs e)
        {
            FromDtPicker.MaxDate = DateTime.Now;
        }

        private void ToDtPicker_Enter(object sender, EventArgs e)
        {
            ToDtPicker.MaxDate = DateTime.Now;
        }

        private void FromDtPicker_ValueChanged(object sender, EventArgs e)
        {
            ToDtPicker.MinDate = Convert.ToDateTime(FromDtPicker.Value.ToString());
        }

        private void StatementsUserControl_Load(object sender, EventArgs e)
        {
            this.LedgerView.Hide();
            this.MTHeadLbl.Hide();
            this.ProfitAndLossAcLbl.Hide();
            this.ReceivableLbl.Hide();
            this.ReceivableEntryLbl.Hide();
            this.ReceivedLbl.Hide();
            this.ReceivedEntryLbl.Hide();
            this.BalanceEntryLbl.Hide();
            this.BalanceLbl.Hide();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
            con.Open();
            string query = "SELECT SUM(SalesAmt), SUM(AmazonFees), SUM(Shipping) from Sales where Date >= '"+this.FromDtPicker.Value.ToString("dd-MMM-yy")+ "' and Date <= '"+this.ToDtPicker.Value.ToString("dd-MMM-yy")+ "' ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            this.MTHeadLbl.Show();
            this.ProfitAndLossAcLbl.Show();
            this.LedgerView.Show();
            SalesEntryLbl.Text = Convert.ToString(dt.Rows[0][0]);
            FeesEntryLbl.Text = Convert.ToString(dt.Rows[0][1]);
            ShippingEntryLbl.Text = Convert.ToString(dt.Rows[0][2]);
            string query1 = "SELECT SUM(Amount_Debited) from SalesReturns where Date >= '" + this.FromDtPicker.Value.ToString("dd-MMM-yy") + "' and Date <= '" + this.ToDtPicker.Value.ToString("dd-MMM-yy") + "' ";
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            SalesReturnsEntryLbl.Text = "("+Convert.ToString(dt1.Rows[0][0])+ ") ";
            NetSalesEntryLbl.Text = Convert.ToString((Convert.ToDouble(dt.Rows[0][0]) - Convert.ToDouble(dt1.Rows[0][0])));
            TotalLbl1.Text = TotalLbl2.Text = NetSalesEntryLbl.Text;
            NetProfitEntryLbl.Text = Convert.ToString(Convert.ToDouble(NetSalesEntryLbl.Text) - Convert.ToDouble(FeesEntryLbl.Text) - Convert.ToDouble(ShippingEntryLbl.Text));
            string query2 = "SELECT SUM(Amount) from Payments where Date >= '" + this.FromDtPicker.Value.ToString("dd-MMM-yy") + "' and Date <= '" + this.ToDtPicker.Value.ToString("dd-MMM-yy") + "' ";
            SqlDataAdapter SDA2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            SDA2.Fill(dt2);
            this.ReceivableLbl.Show();
            this.ReceivableEntryLbl.Show();
            this.ReceivedLbl.Show();
            this.ReceivedEntryLbl.Show();
            this.BalanceEntryLbl.Show();
            this.BalanceLbl.Show();
            ReceivableEntryLbl.Text = NetProfitEntryLbl.Text;
            ReceivedEntryLbl.Text = Convert.ToString(dt2.Rows[0][0]);
            if(ReceivedEntryLbl.Text!="")
                BalanceEntryLbl.Text = Convert.ToString(Convert.ToDouble(NetProfitEntryLbl.Text) - Convert.ToDouble(ReceivedEntryLbl.Text));
            con.Close();
        }
    }
}
