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

        private void sendReview_Click(object sender, EventArgs e)
        {
            if (email.Text != String.Empty && review.Text != String.Empty)
            {
                try
                {
                    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reviews (Email, Review) VALUES (@Email, @Review)", cn);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Review", review.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item successfully created");
                    email.Clear();
                    review.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }
    }
}
