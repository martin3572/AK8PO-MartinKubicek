using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDatabase
{
     public class Meal
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public MemoryStream ProductImage { get; set; }
        public int ProductCategoryID { get; set; }
    }
}
