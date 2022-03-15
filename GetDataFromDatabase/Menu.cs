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
    public partial class Menu : UserControl
    {
        List<Menu> menu = new List<Menu>();
        public Menu()
        {
            InitializeComponent();
            DataAccess db = new DataAccess();
            menu = db.GetMeals();
            //product.Text = menu.ToString();
        }

        private void product_Click(object sender, EventArgs e)
        {

        }
    }
}

/* Vkladanie zaznamu s obrazkom
 * 
 INSERT INTO Menu (ProductName, ProductPrice, ProductImage)
SELECT 'Hamburger', '180', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\marti\source\repos\GetDataFromDatabase\GetDataFromDatabase\Images\hamburger.jpg', Single_Blob) as image
*/