/* CustomerUpdateApp.cs
 * This application illustrates using program statements to access data. 
 * The customer number, customer name, and customer area are stored
 * in a datagrid. Data can be updated and written 
 * back to the database.
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

namespace CustomerUpdateApp
{
    public partial class CustomerUpdateApp : Form
    {
        private OleDbDataAdapter custDataAdap;
        private DataSet custDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;

        public CustomerUpdateApp()
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

                sql = "SELECT customerNumber, customerLastName, customerFirstName FROM CustomerTable ORDER BY customerLastName";

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
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(custDataAdap);
                custDataAdap.Update(custDS, "CustomerTable");
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
