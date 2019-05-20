/* PublicationApp.cs
 * This application displays data from two tables,
 * BookTable and CourseBookTable. 
 * 
 * No program statements were typed. After the
 * Database Configuration Tools Wizard was used
 * to establish a connection, the dataset (BooksDataSet.xsd)
 * was opened. The BookTableAdapter's Select SQL statement
 * was modified to return fields from both tables. After
 * the datagrid was dragged to the form, the smart tag
 * was used to remove and format columns.
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

namespace PublicationApp
{
    public partial class FrmPublicationApp : Form
    {
        public FrmPublicationApp()
        {
            InitializeComponent();
        }

        private void bookTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.booksDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.BookTable' table. You can move, or remove it, as needed.
            this.bookTableTableAdapter.Fill(this.booksDataSet.BookTable);
        }
    }
}
