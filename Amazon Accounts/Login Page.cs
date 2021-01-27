using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amazon_Accounts
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTxt.PasswordChar = '\0';
            }

            else
                PasswordTxt.PasswordChar = '•';
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignupLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_UpForm f1 = new Sign_UpForm();
            f1.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UseriDtxt.Text!="" && PasswordTxt.Text!="")
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
                con.Open();
                int Id = Convert.ToInt32(UseriDtxt.Text);
                string query = "select * from Login where UserId = '" + Id + "' and UserPassword = '" + this.PasswordTxt.Text + "' ";
                SqlDataAdapter DA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                try
                {
                    DA.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Welcome to Mahipal Textiles", "Mahipal Textiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        this.Hide();
                        Home_Page h1 = new Home_Page();
                        h1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserId or password");
                        FocusInput();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Login", MessageBoxButtons.OK);
                FocusInput();
            }
            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = UseriDtxt;
            UseriDtxt.Focus();
        }

        private void FocusInput()
        {
            UseriDtxt.Focus();
        }
    }
}
