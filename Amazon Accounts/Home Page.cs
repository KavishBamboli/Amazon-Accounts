using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon_Accounts
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();

        }

        private void SalesPageBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalesPageBtn.Height;
            SidePanel.Top = SalesPageBtn.Top;
            salesUserControl1.BringToFront();
        }

        private void ReportsPageBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReportsPageBtn.Height;
            SidePanel.Top = ReportsPageBtn.Top;
            reportsUserControl1.BringToFront();
        }

        private void SalesReturnPagePageBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SalesReturnPagePageBtn.Height;
            SidePanel.Top = SalesReturnPagePageBtn.Top;
            salesreturnsUserControl1.BringToFront();
        }

        private void StatementsPageBtn_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = StatementsPageBtn.Height;
            SidePanel.Top = StatementsPageBtn.Top;
            statementsUserControl1.BringToFront();
        }

        private void ExitAppBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, you want to exit", "Exit application", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            SidePanel.Height = SalesPageBtn.Height;
            salesUserControl1.BringToFront();
            salesUserControl1.BringToFront();
        }

        private void CancelledBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CancelledBtn.Height;
            SidePanel.Top = CancelledBtn.Top;
            cancelledOrderUserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = PaymentsBtn.Height;
            SidePanel.Top = PaymentsBtn.Top;
            paymentsUserControl1.BringToFront();
        }
    }
}
