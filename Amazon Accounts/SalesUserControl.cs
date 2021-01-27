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
using System.Windows.Automation.Peers;

namespace Amazon_Accounts
{
    public partial class SalesUserControl : UserControl
    {
        public SalesUserControl()
        {
            InitializeComponent();
        }
        private void GrossAmtTxt_TextChanged(object sender, EventArgs e)
        {
            if(GrossAmtTxt.Text!="")
            {
                try
                {
                    int salesAmt = Convert.ToInt32(SalesAmtTxt.Text);
                    double grossAmt = Convert.ToDouble(GrossAmtTxt.Text);
                    if ((salesAmt - grossAmt) < 0)
                    {
                        MessageBox.Show("Fees cannot be negative", "Sales Page");
                        GrossAmtTxt.Focus();
                        GrossAmtTxt.Text = "";
                    }
                    else
                    {
                        ReceivableCalc(salesAmt, grossAmt);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void ShippingTxt_TextChanged(object sender, EventArgs e)
        {
            if(ShippingTxt.Text!="")
            {
                try
                {
                    int salesAmt = Convert.ToInt32(SalesAmtTxt.Text);
                    double grossAmt = Convert.ToDouble(GrossAmtTxt.Text);
                    double Shipping = Convert.ToDouble(ShippingTxt.Text);
                    ReceivableCalc(salesAmt, grossAmt, Shipping);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sellercentral.amazon.in/gp/payments-account/view-transactions.html?ref_=xx_trans_ttab_dash");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OrderIdTxt.Text);
        }
        #region ToolTip code
        private void DateTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the date of order", DateTxt);
        }

        private void InvoiceNoTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the invoice number", InvoiceNoTxt);
        }

        private void OrderIdTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the Order Id", OrderIdTxt);
        }

        private void SalesAmtTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the sales amount including shipping charged and GST", SalesAmtTxt);
        }

        private void GrossAmtTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the amount shown in the order detail page after deductions", GrossAmtTxt);
        }

        private void FeesTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("This is the net fees deducted", FeesTxt);
        }

        private void ShippingTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Enter the shipping charged as shown i nthe order detail page", ShippingTxt);
        }

        private void ReceivableTxt_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("This is the net amount receivable", ReceivableTxt);
        }

        private void CopyBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Click here to copy the Order ID", CopyBtn);
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Click here to navigate to the amazon order detail page", linkLabel1);
        }
        #endregion

        private void SalesUserControl_Load(object sender, EventArgs e)
        {
            this.ActiveControl = DateTxt;
        }

        private void EnterSalesBtn_Click(object sender, EventArgs e)
        {
            if (DateTxt.Text != "" && InvoiceNoTxt.Text != "" && OrderIdTxt.Text != "" && SalesAmtTxt.Text != "" && GrossAmtTxt.Text != "" && FeesTxt.Text != "" && ShippingTxt.Text != "" && ReceivableTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to enter?", "Sales Page", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
                        con.Open();
                        string query1 = "select * from Sales where InvoiceNo = '" + this.InvoiceNoTxt.Text + "' ";
                        SqlDataAdapter SDA = new SqlDataAdapter(query1, con);
                        DataTable dt = new DataTable();
                        SDA.Fill(dt);
                        con.Close();
                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("This invoice number already exists", "Sales Page");
                            InvoiceNoTxt.Focus();
                        }
                        else
                        {
                            con.Open();
                            int salesAmt = Convert.ToInt32(SalesAmtTxt.Text);
                            double grossAmt = Convert.ToDouble(GrossAmtTxt.Text);
                            double Fees = Convert.ToDouble(FeesTxt.Text);
                            double Shipping = Convert.ToDouble(ShippingTxt.Text);
                            double Receivable = Convert.ToDouble(ReceivableTxt.Text);
                            string date = Convert.ToDateTime(DateTxt.Text).ToString("dd-MM-yyyy");
                            string query = "INSERT INTO Sales (OrderId, InvoiceNo, Date, SalesAmt, GrossAmt, AmazonFees, Shipping, Receivable) VALUES ('" + this.OrderIdTxt.Text + "', '" + this.InvoiceNoTxt.Text + "', '" + Convert.ToDateTime(date) + "', '" + salesAmt + "', '" + grossAmt + "','" + Fees + "', '" + Shipping + "', '" + Receivable + "')";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data saved successfully", "Sales Page", MessageBoxButtons.OK);
                            con.Close();
                            InvoiceNoTxt.Text = "";
                            OrderIdTxt.Text = "";
                            SalesAmtTxt.Text = "";
                            GrossAmtTxt.Text = "";
                            FeesTxt.Text = "";
                            ShippingTxt.Text = "";
                            ReceivableTxt.Text = "";
                            DateTxt.Focus();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
                MessageBox.Show("Please enter the data for all the fields", "Sales Page");
        }

        private void SalesAmtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GrossAmtTxt_Enter(object sender, EventArgs e)
        {
            if (SalesAmtTxt.Text=="")
            {
                MessageBox.Show("Enter sales amount first", "Sales Page");
                SalesAmtTxt.Focus();
            }
        }

        private void ShippingTxt_Enter(object sender, EventArgs e)
        {
            if(SalesAmtTxt.Text=="" || GrossAmtTxt.Text=="")
            {
                MessageBox.Show("Enter the previous details first", "Sales Page");
                SalesAmtTxt.Focus();
            }
        }

        private void ReceivableTxt_TextChanged(object sender, EventArgs e)
        {
            if (GrossAmtTxt.Text == "" || ShippingTxt.Text == "")
                ReceivableTxt.Text = "";
        }

        private void ReceivableCalc(int Sales, double gross, double shipping = 0)
        {
            double receivable = Sales - (Sales - gross) - shipping;
            FeesTxt.Text = Convert.ToString(Sales - gross);
            ReceivableTxt.Text = Convert.ToString(receivable);
        }

        private void InvoiceNoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void OrderIdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 45)
                e.Handled = true;
        }

        private void GrossAmtTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
                e.Handled = true;
        }

        private void ShippingTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
                e.Handled = true;
        }

        private void DateTxt_Enter(object sender, EventArgs e)
        {
                if (!String.IsNullOrEmpty(DateTxt.Text))
                {
                    DateTxt.SelectionStart = 0;
                    DateTxt.SelectionLength = DateTxt.Text.Length;
                }
        }
    }
}
