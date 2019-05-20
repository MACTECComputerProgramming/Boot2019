/* CustomerDisplayApp.cs
 * This program loads a table from the Customer
 * database. It displays the customer number and name. Users can select 
 * a record in the table and the customer name and numbers selected are
 * displayed in textboxes.
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
    public partial class CustomerDisplayApp : Form
    {
        private OleDbDataAdapter custDataAdap;
        private DataSet custDS;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;

        public CustomerDisplayApp()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dtaGridCustomers.Visible = true;
            try
            {
                sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=../../Customers.accdb";
                OleDbConnection dbConn;
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                sql = "SELECT customerNumber, customerLastName, customerFirstName, customerLocation FROM CustomerTable ORDER BY customerLastName";

                dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                custDataAdap = new OleDbDataAdapter();
                custDataAdap.SelectCommand = dbCmd;
                custDS = new DataSet();
                custDataAdap.Fill(custDS, "CustomerTable");

                this.dtaGridCustomers.DataSource = custDS;
                dtaGridCustomers.DataMember = "CustomerTable";


                dbConn.Close();
                btnShowRecord.Visible = true;
                btnLoadData.Visible = false;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            MakeRecordsVisible();
            try
            {
                txtBxNumber.Text = dtaGridCustomers[0, dtaGridCustomers.CurrentRow.Index].Value.ToString();
                txtBxName.Text = dtaGridCustomers[2, dtaGridCustomers.CurrentRow.Index].Value.ToString() +
                    " " +
                    dtaGridCustomers[1, dtaGridCustomers.CurrentRow.Index].Value.ToString();
                txtBxLocation.Text = GetLocation();
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        public void MakeRecordsVisible()
        {
            lblCustomer.Visible = true;
            lblName.Visible = true;
            lblLocation.Visible = true;
            txtBxNumber.Visible = true;
            txtBxName.Visible = true;
            txtBxLocation.Visible = true;
        }

        public string GetLocation()
        {
            string result;
            string direction = dtaGridCustomers[3, dtaGridCustomers.CurrentRow.Index].Value.ToString();
            switch(direction)
            {
                case "W" :
                case "w" :
                    result = "West";
                    break;
                case "N" :
                case "n" :
                    result = "North";
                    break;
                case "E" :
                case "e" :
                    result = "East";
                    break;
                case "S" :
                case "s" :
                    result = "South";
                    break;
                default:
                    result = "Unknown";
                    break;
            }
            return result;
        }
    }
}
