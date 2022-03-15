using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace GetDataFromDatabase
{
    class DataAccess
    {
        IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectToDB("GetDataFromDatabase.Properties.Settings.AK8POConnectionString"));
       public List<Admin> GetAdmin (string Username, string Password)
        {
            return connection.Query<Admin>($"Select * from Admin where Username = '{Username}' and Password = '{Password}'").ToList();
        }
        public List<Menu> GetMeals()
        {
            //another call to retireve data;
            return new List<Menu>();
        }
    }
}
