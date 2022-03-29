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

        private void addNew_Click(object sender, EventArgs e)
        {
            if (pictureBox != null && pictureBox.ImageLocation != null && productname.Text != String.Empty && productprice.Text != String.Empty)
            {
                try
                {
                    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductName, ProductPrice, ProductImage, CategoryID) VALUES (@ProductName, @ProductPrice, @ProductImage, @CategoryID)", cn);
                    cmd.Parameters.AddWithValue("@ProductName", productname.Text);
                    cmd.Parameters.AddWithValue("@ProductPrice", productprice.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", cbProductcategory.SelectedValue);

                    string filename = pictureBox.ImageLocation.ToString();
                    String strBLOBFilePath = filename; //Modify this path as needed.

                    //Read jpg into file stream, and from there into Byte array.
                    FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                    Byte[] bytProductImage = new Byte[fsBLOBFile.Length];
                    fsBLOBFile.Read(bytProductImage, 0, bytProductImage.Length);
                    fsBLOBFile.Close();

                    //Create parameter for insert command and add to SqlCommand object.
                    SqlParameter prm = new SqlParameter("@ProductImage", SqlDbType.VarBinary, bytProductImage.Length, ParameterDirection.Input, false,
                    0, 0, null, DataRowVersion.Current, bytProductImage);
                    cmd.Parameters.Add(prm);

                    //Open connection, execute query, and close connection.
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item successfully created");
                    productname.Clear();
                    productprice.Clear();
                    pictureBox.Image = null;

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

        private void discardImage_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void insertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = Path.GetFullPath(dialog.FileName);
                pictureBox.ImageLocation = imageLocation;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                conn.Open();
                SqlCommand getCategory = new SqlCommand("select CategoryID, CategoryName from Categories", conn);
                SqlDataReader reader = getCategory.ExecuteReader();

                var list = reader.Cast<IDataRecord>()
                 .Select(dr => new Category { CategoryID = dr.GetInt32(0), CategoryName = dr.GetString(1) })
                 .ToList();

                cbProductcategory.DataSource = list;
                cbProductcategory.DisplayMember = "CategoryName";
                cbProductcategory.ValueMember = "CategoryID";
                Category obj = cbProductcategory.SelectedItem as Category;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
