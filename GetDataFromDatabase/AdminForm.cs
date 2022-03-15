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
    public partial class AdminForm : UserControl
    {
        public bool LoggedIn { get; set; }
        public AdminForm()
        {
            LoggedIn = true;
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
            Visible = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddNewItem addNewItemClass = new AddNewItem();
            addNewItemClass.Location = new Point(190, 80);
            this.Hide();
            this.Parent.Controls.Add(addNewItemClass);
        }
    }
}
