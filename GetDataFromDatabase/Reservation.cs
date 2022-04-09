using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GetDataFromDatabase
{
    public partial class Reservation : UserControl
    {
        List<Table> tableList = new List<Table>();
        Table table = new Table();
        List<ExistingReservations> reservationList = new List<ExistingReservations>();
        ExistingReservations reservation = new ExistingReservations();
        public Reservation()
        {
            InitializeComponent();
            warningMessage.Visible = false;
        }
        private void GetTablesFromDB()
        {
            tableList = new List<Table>();
            //getting products
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from AvailableTables", conn);
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                table = new Table();
                table.TableID = Convert.ToInt32(reader["Id"]); ;
                table.TableName = reader.GetString(1);
                table.GuestCount = Convert.ToInt32(reader["GuestCount"]);
                tableList.Add(table);
            }
            conn.Close();
        }

        private void GetReservationsFromDB()
        {
            try
            {
                reservationList = new List<ExistingReservations>();
                //getting products
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("Select * from Reservation", conn);
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reservation = new ExistingReservations();
                        reservation.ReservationID = Convert.ToInt32(reader["Id"]); ;
                        reservation.GuestName = reader.GetString(1);
                        reservation.ReservationDate = reader.GetDateTime(2);
                        reservation.TableID = Convert.ToInt32(reader["TableID"]);
                        reservationList.Add(reservation);
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Table> GetAvailableTables(DateTime date)
        {
            List<Table> availableTables = new List<Table>();
            availableTables = tableList;
            List<ExistingReservations> choosedDateReservations = new List<ExistingReservations>();
            for (int i = 0; i < reservationList.Count; i++)
            {
                if (reservationList[i].ReservationDate == date)
                {
                    choosedDateReservations.Add(reservationList[i]);
                }
            }

            //Na zaklade toho datumu sa vyberu available pocty ludi.
            for (int i = 0; i < choosedDateReservations.Count; i++)
            {
                availableTables.RemoveAll(p => p.TableID == choosedDateReservations[i].TableID);
            }

            return availableTables;
        }

        private List<GuestCount> GetGuestCount(List<Table> availableTables)
        {
            List<GuestCount> guestCount = new List<GuestCount>();
            List<int> tmp = availableTables.Select(x => x.GuestCount).Distinct().ToList();
            for (int i = 0; i < tmp.Count(); i++)
            {
                GuestCount number = new GuestCount();
                number.CountID = i + 1;
                number.Count = tmp[i];
                guestCount.Add(number);
            }
            return guestCount;
        }

        private List<Table> GetAvailableTablesByGuestCount(List<Table> allAvailableTables, int selectedIndex)
        {
            List<Table> availableTables = new List<Table>();
            for (int i = 0; i < allAvailableTables.Count; i++)
            {
                if (allAvailableTables[i].GuestCount == selectedIndex)
                {
                    availableTables.Add(allAvailableTables[i]);
                }
            }
            return availableTables;
        }

        private void cbGuestCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTablesFromDB();
            int selectedCount = 0;
            DateTime date = datetime.Value.Date;
            List<Table> availableTables = new List<Table>();
            try
            {
                selectedCount = Convert.ToInt32(cbGuestCount.Text);
            }
            catch
            {
                //MessageBox.Show(ex.Message); //thrown when loading idk why
            }

            availableTables = GetAvailableTables(date);
            availableTables = GetAvailableTablesByGuestCount(availableTables, selectedCount);

            cbAvailableTables.DataSource = availableTables;
            cbAvailableTables.DisplayMember = "TableName";
            cbAvailableTables.ValueMember = "TableId";
            Table obj = cbAvailableTables.SelectedItem as Table;
        }

        private void cbAvailableTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            GetReservationsFromDB();
            GetTablesFromDB();

            DateTime date = datetime.Value.Date;
            List<Table> availableTables = GetAvailableTables(date);
            List<GuestCount> guestCount = GetGuestCount(availableTables);

            availableTables = GetAvailableTablesByGuestCount(availableTables, guestCount[0].Count);

            //available counts for people that can sit in one table
            cbGuestCount.DataSource = guestCount;
            cbGuestCount.DisplayMember = "Count";
            cbGuestCount.ValueMember = "CountID";
            GuestCount obj1 = cbGuestCount.SelectedItem as GuestCount;

            //Po vybere poctu ludi sa zobrazia stoly, ktore maju dany pocet ludi a su volne                      
            cbAvailableTables.DataSource = availableTables;
            cbAvailableTables.DisplayMember = "TableName";
            cbAvailableTables.ValueMember = "TableId";
            Table obj = cbAvailableTables.SelectedItem as Table;

        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            GetTablesFromDB();
            DateTime date = datetime.Value.Date;
            int selectedCount = Convert.ToInt32(cbGuestCount.Text);
            List<Table> availableTables = new List<Table>();

            availableTables = GetAvailableTables(date);
            List<GuestCount> guestCount = GetGuestCount(availableTables);

            //available counts for people that can sit in one table
            cbGuestCount.DataSource = guestCount;
            cbGuestCount.DisplayMember = "Count";
            cbGuestCount.ValueMember = "CountID";
            GuestCount obj1 = cbGuestCount.SelectedItem as GuestCount;

            //Po vybere poctu ludi sa zobrazia stoly, ktore maju dany pocet ludi a su volne
            try
            {
                availableTables = GetAvailableTablesByGuestCount(availableTables, guestCount[0].Count);
            }
            finally
            {
                cbAvailableTables.DataSource = availableTables;
                cbAvailableTables.DisplayMember = "TableName";
                cbAvailableTables.ValueMember = "TableId";
                Table obj = cbAvailableTables.SelectedItem as Table;
            }

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            if (guestName.Text != String.Empty)
            {
                try
                {
                    SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AK8PO;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reservation (ReservationDate, TableID, GuestName) VALUES (@ReservationDate, @TableID, @GuestName)", cn);
                    cmd.Parameters.AddWithValue("@ReservationDate", datetime.Value.Date);
                    cmd.Parameters.AddWithValue("@TableID", cbAvailableTables.SelectedValue);
                    cmd.Parameters.AddWithValue("@GuestName", guestName.Text);

                    //Open connection, execute query, and close connection.
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item successfully created");

                    DateTime date = datetime.Value.Date;
                    int selectedCount = Convert.ToInt32(cbGuestCount.Text);
                    GetReservationsFromDB();
                    GetTablesFromDB();
                    List<Table> availableTables = GetAvailableTables(date);
                    List<GuestCount> guestCount = GetGuestCount(availableTables);
                    availableTables = GetAvailableTablesByGuestCount(availableTables, guestCount[0].Count);

                    //available counts for people that can sit in one table
                    cbGuestCount.DataSource = guestCount;
                    cbGuestCount.DisplayMember = "Count";
                    cbGuestCount.ValueMember = "CountID";
                    GuestCount obj1 = cbGuestCount.SelectedItem as GuestCount;

                    //Po vybere poctu ludi sa zobrazia stoly, ktore maju dany pocet ludi a su volne

                    cbAvailableTables.DataSource = availableTables;
                    cbAvailableTables.DisplayMember = "TableName";
                    cbAvailableTables.ValueMember = "TableId";
                    Table obj = cbAvailableTables.SelectedItem as Table;
                    guestName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                warningMessage.Visible = true;
            }


        }

        private void guestName_TextChanged(object sender, EventArgs e)
        {
            warningMessage.Visible = false;
        }
    }
}

