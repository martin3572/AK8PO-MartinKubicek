using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDataFromDatabase
{
    public partial class Menu : UserControl
    {
        List<Meal> mealList = new List<Meal>();
        Meal meal = new Meal();
        List<Category> categoryList = new List<Category>();
        List<Meal> mealByCategory = new List<Meal>();
        int choosedItem = new int();

        public Menu()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            productImage.SizeMode = PictureBoxSizeMode.StretchImage;
            //getting categories
            try
            {
                categoryList = GetCategoryFromDB();
                cbProductcategory.DataSource = categoryList;
                cbProductcategory.DisplayMember = "CategoryName";
                cbProductcategory.ValueMember = "CategoryID";
                Category obj = cbProductcategory.SelectedItem as Category;
                GetMenuFromDB();
                List<Meal> mealByCategory = new List<Meal>();
                for (int i = 0; i < mealList.Count; i++)
                {
                    if (mealList[i].ProductCategoryID == Convert.ToInt32(cbProductcategory.SelectedValue))
                    {
                        mealByCategory.Add(mealList[i]);
                    }
                }
                var countOfProducts = 0;
                countOfProducts = mealByCategory.Count;
                productCount.Text = "Produkty: " + countOfProducts;
                productPrice.Text = mealByCategory[0].ProductPrice.ToString() + " Kč";
                productName.Text = mealByCategory[0].ProductName;
                productImage.Image = Image.FromStream(mealByCategory[0].ProductImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetMenuFromDB()
        {
            mealList = new List<Meal>();
            //getting products
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Menu", conn);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                meal = new Meal();
                meal.Id = Convert.ToInt32(reader["Id"]); ;
                meal.ProductName = reader.GetString(1);
                meal.ProductPrice = Convert.ToInt32(reader["ProductPrice"]);
                meal.ProductImage = getImageFromDB(meal.Id);
                meal.ProductCategoryID = reader.GetInt32(4);
                mealList.Add(meal);
            }
            conn.Close();
        }

        private List<Category> GetCategoryFromDB()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
            conn.Open();
            SqlCommand getCategory = new SqlCommand("select CategoryID, CategoryName from Categories", conn);
            SqlDataReader reader = getCategory.ExecuteReader();

            return reader.Cast<IDataRecord>()
             .Select(dr => new Category { CategoryID = dr.GetInt32(0), CategoryName = dr.GetString(1) })
             .ToList();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            List<Meal> mealByCategory = new List<Meal>();
            cbProductcategory.DataSource = categoryList;
            cbProductcategory.DisplayMember = "CategoryName";
            cbProductcategory.ValueMember = "CategoryID";
            Category obj = cbProductcategory.SelectedItem as Category;

            for (int i = 0; i < mealList.Count; i++)
            {

                if (mealList[i].ProductCategoryID == Convert.ToInt32(cbProductcategory.SelectedValue))
                {
                    mealByCategory.Add(mealList[i]);
                }
            }
            if (choosedItem == 0)
            {
                choosedItem = mealByCategory.Count-1;
            }
            else
            {
                choosedItem--;
            }
            productPrice.Text = mealByCategory[choosedItem].ProductPrice.ToString() + " Kč";
            productName.Text = mealByCategory[choosedItem].ProductName;
            productImage.Image = Image.FromStream(mealByCategory[choosedItem].ProductImage);
        }

        private void next_Click(object sender, EventArgs e)
        {
            List<Meal> mealByCategory = new List<Meal>();
            cbProductcategory.DataSource = categoryList;
            cbProductcategory.DisplayMember = "CategoryName";
            cbProductcategory.ValueMember = "CategoryID";
            Category obj = cbProductcategory.SelectedItem as Category;

            for (int i = 0; i < mealList.Count; i++)
            {

                if (mealList[i].ProductCategoryID == Convert.ToInt32(cbProductcategory.SelectedValue))
                {
                    mealByCategory.Add(mealList[i]);
                }
            }
            if (choosedItem == mealByCategory.Count-1)
            {
                choosedItem = 0;
            }
            else
            {
                choosedItem++;
            }
            productPrice.Text = mealByCategory[choosedItem].ProductPrice.ToString() + " Kč";
            productName.Text = mealByCategory[choosedItem].ProductName;
            productImage.Image = Image.FromStream(mealByCategory[choosedItem].ProductImage);
        }
        
        private MemoryStream getImageFromDB(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                cn.Open();
                MemoryStream stmProductImage = new MemoryStream();
                //Retrieve image from database into DataSet.
                SqlCommand cmd = new SqlCommand("SELECT ProductImage FROM Menu where Id=@Id", cn);
                cmd.Parameters.AddWithValue("Id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds, "Menu");
                int c = ds.Tables["Menu"].Rows.Count;
                
                if (c > 0)
                {
                    Byte[] byteProductImage = new Byte[0];
                    byteProductImage = (Byte[])(ds.Tables["Menu"].Rows[c - 1]["ProductImage"]);
                    stmProductImage = new MemoryStream(byteProductImage);
                }
                cn.Close();
                return stmProductImage;              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cbProductcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mealList.Count == 0)
            {
                GetMenuFromDB();
            }

            try
            {               
                List<Meal> mealByCategory = new List<Meal>();
                cbProductcategory.DataSource = categoryList;
                cbProductcategory.DisplayMember = "CategoryName";
                cbProductcategory.ValueMember = "CategoryID";
                Category obj = cbProductcategory.SelectedItem as Category;
                for (int i = 0; i < mealList.Count; i++)
                {
                    
                    if (mealList[i].ProductCategoryID == Convert.ToInt32(cbProductcategory.SelectedValue))
                    {
                        mealByCategory.Add(mealList[i]);
                    }
                }
                var countOfProducts = 0;
                countOfProducts = mealByCategory.Count;
                if(countOfProducts == 0)
                {
                    MessageBox.Show("V ponuke nie su ziadne polozky danej kategorie");
                }
                else
                {
                    productCount.Text = "Produkty: " + countOfProducts;
                    productPrice.Text = mealByCategory[choosedItem].ProductPrice.ToString() + " Kč";
                    productName.Text = mealByCategory[choosedItem].ProductName;
                    productImage.Image = Image.FromStream(mealByCategory[choosedItem].ProductImage);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

/* Vkladanie zaznamu s obrazkom
 * 
 INSERT INTO Menu (ProductName, ProductPrice, ProductImage)
SELECT 'Hamburger', '180', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\marti\source\repos\GetDataFromDatabase\GetDataFromDatabase\Images\hamburger.jpg', Single_Blob) as image
*/