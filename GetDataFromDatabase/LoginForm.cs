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

namespace GetDataFromDatabase
{
    public partial class LoginForm : UserControl
    {
        public bool LoggedIn { get; set; }
        List<Admin> admin = new List<Admin>();
        public LoginForm()
        {
            InitializeComponent();
            incorectLogin.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Id from Admin where Username=@Username AND Password=@Password", conn);
            cmd1.Parameters.AddWithValue("Username", username.Text);
            cmd1.Parameters.AddWithValue("Password", password.Text);
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {               
                AddNewItem addNewItemClass = new AddNewItem();
                this.Hide();//because usercontrols have not Close() property as forms
                this.Parent.Controls.Add(addNewItemClass);
                addNewItemClass.Location = new Point(190, 80);
                LoggedIn = true;
                incorectLogin.Visible = false;
            }
            else
            {
                LoggedIn = false;
                incorectLogin.Visible = true;
                username.Clear();
                password.Clear();
            }                     
            conn.Close();
        }

        private void discardUsername_Click(object sender, EventArgs e)
        {
            username.Clear();
        }

        private void discardPassword_Click(object sender, EventArgs e)
        {
            password.Clear();
        }
    }
}
