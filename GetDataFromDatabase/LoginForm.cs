using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            DataAccess db = new DataAccess();
            admin = db.GetAdmin(username.Text, password.Text);
            if (admin.Any())
            {
                AdminForm adminFormClass = new AdminForm();
                this.Hide();//because usercontrols have not Close() property as forms
                this.Parent.Controls.Add(adminFormClass);
                adminFormClass.Location = new Point(190, 80);
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
