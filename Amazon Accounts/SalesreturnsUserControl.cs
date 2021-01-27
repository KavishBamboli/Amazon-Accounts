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
    public partial class SalesreturnsUserControl : UserControl
    {
        public SalesreturnsUserControl()
        {
            InitializeComponent();
        }
        #region Tool Tip codes
        private void OrderIdTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the Order ID", OrderIdTxt);
        }

        private void AmtDebitedTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the amount debited as shown in the amazon order detail page", AmtDebitedTxt);
        }

        private void GrossLossTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("This is the gross loss incurred excluding shipping", GrossLossTxt);
        }

        private void ShippingTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("This is the shipping charged", ShippingTxt);
        }

        private void NetLoss_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("This is the net loss incurred after shipping charges", NetLoss);
        }

        private void CopyBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Click here to copy the order ID", CopyBtn);
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Click here to navigate to Amazon Order detail page", linkLabel1);
        }
        #endregion
        double Gross_Amt, shipping;
        string date, invoiceNo;
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OrderIdTxt.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sellercentral.amazon.in/gp/payments-account/view-transactions.html?ref_=xx_trans_ttab_dash");
        }

        private void SalesreturnsUserControl_Load(object sender, EventArgs e)
        {
            OrderIdTxt.Focus();
            this.AmtDebitedLbl.Hide();
            this.AmtDebitedTxt.Hide();
            this.GrossLossLbl.Hide();
            this.GrossLossTxt.Hide();
            this.ShippingLbl.Hide();
            this.ShippingTxt.Hide();
            this.NetLossLbl.Hide();
            this.NetLoss.Hide();
            this.CopyBtn.Hide();
            this.linkLabel1.Hide();
            this.EnterSalesReturnsBtn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    if (dt.Rows.Count == 1)
                    {
                        SalesDetailsView.DataSource = dt;
                        this.AmtDebitedLbl.Show();
                        this.AmtDebitedTxt.Show();
                        this.GrossLossLbl.Show();
                        this.GrossLossTxt.Show();
                        this.ShippingLbl.Show();
                        this.ShippingTxt.Show();
                        this.NetLossLbl.Show();
                        this.NetLoss.Show();
                        this.CopyBtn.Show();
                        this.linkLabel1.Show();
                        this.EnterSalesReturnsBtn.Show();
                        AmtDebitedTxt.Focus();
                        shipping = Convert.ToDouble(dt.Rows[0][7]);
                        Gross_Amt = Convert.ToDouble(dt.Rows[0][5]);
                        date = Convert.ToDateTime(dt.Rows[0][3]).ToString("dd-MM-yyyy");
                        invoiceNo = Convert.ToString(dt.Rows[0][2]);
                        ShippingTxt.Text = Convert.ToString(shipping);
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("The Order ID entered is either wrong or is not found", "Sales Returns Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OrderIdTxt.Focus();
                        OrderIdTxt.Text = "";
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Enter Order ID", "Sales Returns Page");
        }

        private void AmtDebitedTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void EnterSalesReturnsBtn_Click(object sender, EventArgs e)
        {
            if(AmtDebitedTxt.Text!="")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to enter", "Sales Returns Page", MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
                        con.Open();
                        double amtDebited = Convert.ToDouble(AmtDebitedTxt.Text);
                        double GrossLoss = Convert.ToDouble(GrossLossTxt.Text);
                        double shipping = Convert.ToDouble(ShippingTxt.Text);
                        double netLoss = Convert.ToDouble(NetLoss.Text);
                        string query = "INSERT INTO SalesReturns (Date, Order_ID, Invoice_No, Amount_Debited, Gross_Loss, Shipping, Net_Loss) VALUES ('"+Convert.ToDateTime(date)+"', '" + this.OrderIdTxt.Text + "', '"+invoiceNo+ "', '" + amtDebited + "', '" + GrossLoss + "', '" + shipping + "', '" + netLoss + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data entered successfully");
                        con.Close();
                        this.AmtDebitedLbl.Hide();
                        this.AmtDebitedTxt.Hide();
                        this.GrossLossLbl.Hide();
                        this.GrossLossTxt.Hide();
                        this.ShippingLbl.Hide();
                        this.ShippingTxt.Hide();
                        this.NetLossLbl.Hide();
                        this.NetLoss.Hide();
                        this.CopyBtn.Hide();
                        this.linkLabel1.Hide();
                        this.EnterSalesReturnsBtn.Hide();
                        OrderIdTxt.Text = "";
                        AmtDebitedTxt.Text = "";
                        GrossLossTxt.Text = "";
                        ShippingTxt.Text = "";
                        NetLoss.Text = "";
                        OrderIdTxt.Focus();
                        SalesDetailsView.DataSource = "";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter the data for all the fields", "Sales Returns Page");
                AmtDebitedTxt.Focus();
            }
        }

        private void OrderIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 45)
                e.Handled = true;
        }

        private void AmtDebitedTxt_TextChanged(object sender, EventArgs e)
        {
            if(AmtDebitedTxt.Text!="")
            {
                try
                {
                    double amount_Debited = Convert.ToDouble(AmtDebitedTxt.Text);
                    GrossLossTxt.Text = Convert.ToString(amount_Debited - Gross_Amt);
                    NetLoss.Text = Convert.ToString(Convert.ToDouble(GrossLossTxt.Text) + shipping);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
