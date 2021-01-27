using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Amazon_Accounts
{
    public partial class Sign_UpForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-OLTIGBU5;Initial Catalog=CollectionDatabase;Integrated Security=True");
        public Sign_UpForm()
        {
            InitializeComponent();
        }

        private void Sign_UpForm_Load(object sender, EventArgs e)
        {
            FocusInput();
        }

        private void BackLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            this.Hide();
            f2.Show();
        }

        private void FocusInput()
        {
            UserNameTxt.Focus();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (UserIdTxt.Text != "" && UserNameTxt.Text != "" && UserPassTxt.Text != "" && UserCPassTxt.Text != "")
            {
                con.Open();
                int Uid = Convert.ToInt32(UserIdTxt.Text);
                string query1 = "select * from Login where UserId = '" + Uid + "' ";
                SqlDataAdapter DA = new SqlDataAdapter(query1, con);
                DataTable dt = new DataTable();
                DA.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("This ID already exists", "Sign Up");
                    UserIdTxt.Focus();
                }    
                else
                {
                    if (UserPassTxt.Text == UserCPassTxt.Text)
                    {
                        con.Open();
                        string query = "INSERT INTO Login (UserId, UserName, UserPassword) VALUES ('" + Uid + "', '" + this.UserNameTxt.Text + "', '" + this.UserPassTxt.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Welcome! You have successfully signed up", "Mahipal Textiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        this.Hide();
                        LoginForm f2 = new LoginForm();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your password and confirm password does not match", "Sign Up");
                        UserPassTxt.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Sign Up");
                FocusInput();
            }    
        }
    }
}
