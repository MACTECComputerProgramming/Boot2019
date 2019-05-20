/* FrmFamilyApp.cs
 * This application uses the Family.accdb database
 * and displays names and relationship 
 * from the FamiyTable of records of family
 * members that live in the 'Grand Rapids' hometown.
 * It excludes the 'self' record.
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

namespace FamilyApp
{
    public partial class FrmFamilyApp : Form
    {
        public FrmFamilyApp()
        {
            InitializeComponent();
        }

        private void familyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.familyDataSet);
        }

        private void FrmFamilyApp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'familyDataSet.FamilyTable' table. You can move, or remove it, as needed.
            this.familyTableTableAdapter.Fill(this.familyDataSet.FamilyTable);
        }
    }
}
