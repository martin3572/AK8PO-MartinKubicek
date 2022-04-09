using Kubicek_AK8PO;
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
            reviews2.Hide();
            addNewItem1.Hide();
            addReview1.Hide();
        }

        private void order_Click(object sender, EventArgs e)
        {
                menu2.Show();

                reservation1.Hide();
                loginForm1.Hide();
                reviews2.Hide();
                addNewItem1.Hide();
                addReview1.Hide();
        }

        private void reservation_Click(object sender, EventArgs e)
        {
                reservation1.Show();

                menu2.Hide();
                loginForm1.Hide();
                reviews2.Hide();
                addNewItem1.Hide();
                addReview1.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            reservation1.Hide();
            menu2.Hide();
            loginForm1.Hide();
            reviews2.Hide();
            addNewItem1.Hide();
            addReview1.Hide();

            userLoggedIn = loginForm1.LoggedIn;
            if (userLoggedIn == true)
            {
                addNewItem1.Show(); //added now
            }
            else
            {
                LoginForm loginFormClass = new LoginForm();
                loginFormClass.Location = new Point(190, 80);
                this.Controls.Add(loginFormClass);
            }
        }
        private void reviewForm_Click(object sender, EventArgs e)
        {
            reviews2.Show();
            reservation1.Hide();
            loginForm1.Hide();
            menu2.Hide();
            addNewItem1.Hide();
            addReview1.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimalizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void newReview_Click(object sender, EventArgs e)
        {
            addReview1.Show();
            reservation1.Hide();
            loginForm1.Hide();
            menu2.Hide();
            addNewItem1.Hide();
            reviews2.Hide();
        }
    }
}
