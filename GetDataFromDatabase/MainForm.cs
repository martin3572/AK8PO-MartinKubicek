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
    public partial class MainForm : Form
    {

        bool userLoggedIn = false;
        public MainForm()
        {
            InitializeComponent();
            reservation1.Hide();
            menu2.Hide();
            loginForm1.Hide();
            adminForm1.Hide();
            reviews1.Hide();
            addNewItem1.Hide();
        }

        private void order_Click(object sender, EventArgs e)
        {
                menu2.Show();
                reservation1.Hide();
                loginForm1.Hide();
                adminForm1.Hide();
                reviews1.Hide();
        }

        private void reservation_Click(object sender, EventArgs e)
        {
                reservation1.Show();
                menu2.Hide();
                loginForm1.Hide();
                adminForm1.Hide();
                reviews1.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            menu2.Hide();
            reservation1.Hide();
            adminForm1.Hide();
            reviews1.Hide();

            userLoggedIn = loginForm1.LoggedIn;
            if (userLoggedIn == true)
            {
                adminForm1.Show();
                reservation1.Hide();
                menu2.Hide();
                loginForm1.Hide();
                reviews1.Hide();
            }
            else
            {
                LoginForm loginFormClass = new LoginForm();
                loginFormClass.Location = new Point(190, 80);
                this.Controls.Add(loginFormClass);
                reservation1.Hide();
                menu2.Hide();
                adminForm1.Hide();
                reviews1.Hide();
            }
        }
        private void reviewForm_Click(object sender, EventArgs e)
        {
                reviews1.Show();
                reservation1.Hide();
                loginForm1.Hide();
                adminForm1.Hide();
                menu2.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addNewItem1_Load(object sender, EventArgs e)
        {

        }

        private void reservation1_Load(object sender, EventArgs e)
        {

        }

        private void menu2_Load(object sender, EventArgs e)
        {

        }
    }
}
