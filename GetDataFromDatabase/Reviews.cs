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
    public partial class Reviews : UserControl
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void discardReview_Click(object sender, EventArgs e)
        {
            email.Clear();
            review.Clear();
        }
    }
}
