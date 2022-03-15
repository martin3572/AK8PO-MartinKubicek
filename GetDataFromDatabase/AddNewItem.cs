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
    public partial class AddNewItem : UserControl
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminForm adminFormClass = new AdminForm();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(adminFormClass);
            adminFormClass.Location = new Point(190, 80);
        }
    }
}
