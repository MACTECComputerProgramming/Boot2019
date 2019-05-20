/* CustomerApp.cs
 * This program accesses a database. Data includes 
 * customer number, customer name, and customer area.
 * This program displays the names of all customers in
 * a ListBox.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Added for Access


namespace CustomerApp
{
    public partial class FrmCustomerApp : Form
    {
        private string sConnection;
        private OleDbCommand dbCmd;
        private OleDbDataReader dbReader;
        private string sql;

        public FrmCustomerApp()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxNames.Visible = true;
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=../../Customers.accdb"; // stored at the project level
                //"Data Source=Customers.accdb";         // looks in the bin\debug directory for the database

                OleDbConnection dbConn;
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                sql = "SELECT customerFirstName, customerLastName FROM CustomerTable ORDER BY customerLastName";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    lstBxNames.Items.Add((dbReader["customerFirstName"].ToString()) + " " +
                                           (dbReader["customerLastName"].ToString()));
                }

                dbReader.Close();
                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Can not open Database", "Error");
            }
        }
    }
}
