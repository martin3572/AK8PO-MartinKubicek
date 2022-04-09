using System;
using GetDataFromDatabase;
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
        List<Review> reviewList = new List<Review>();
        Review reviewClass = new Review();
        int choosedItem = new int();
        int countOfReviews = 0;
        public bool Adding { get; set; }
        public Reviews()
        {
            InitializeComponent();
            GetReviewFromDB();
            Adding = false;
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            try 
            { 
                countOfReviews = reviewList.Count;
                reviewCount.Text = "Recenzia: " + 1 + "/" + countOfReviews;
                username.Text = reviewList[0].CustomerName;
                review.Text = reviewList[0].ReviewContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetReviewFromDB()
        {
            reviewList = new List<Review>();
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Reviews", conn);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                reviewClass = new Review();
                reviewClass.ReviewID = Convert.ToInt32(reader["Id"]); ;
                reviewClass.CustomerName = reader.GetString(1);
                reviewClass.ReviewContent = reader.GetString(2);
                reviewList.Add(reviewClass);
            }
            conn.Close();
        }

        private void previous_Click(object sender, EventArgs e)
        {           
            if (choosedItem == 0)
            {
                choosedItem = reviewList.Count - 1;
            }
            else
            {
                choosedItem--;
            }
            username.Text = reviewList[choosedItem].CustomerName;
            review.Text = reviewList[choosedItem].ReviewContent;
            reviewCount.Text = "Recenzia: " + (choosedItem+1) + "/" + countOfReviews;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (choosedItem == reviewList.Count-1)
            {
                choosedItem = 0;
            }
            else
            {
                choosedItem++;
            }
            username.Text = reviewList[choosedItem].CustomerName;
            review.Text = reviewList[choosedItem].ReviewContent;
            reviewCount.Text = "Recenzia: " + (choosedItem+1) + "/" + countOfReviews;
        }

        private void discardReview_Click(object sender, EventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            GetReviewFromDB();
            countOfReviews = reviewList.Count;
            reviewCount.Text = "Recenzia: " + (choosedItem + 1) + "/" + countOfReviews;
        }
    }
}
