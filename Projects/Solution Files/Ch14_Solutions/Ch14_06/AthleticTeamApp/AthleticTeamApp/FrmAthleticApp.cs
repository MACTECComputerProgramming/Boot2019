/* FrmAthleticApp.cs
 * This application retrieves data from a database which contains
 * two tables, Team and Athletes. The application displays information 
 * about each team, including the names of the athletes associated with
 * the team.
 * 
 * After a data connection was established using teh
 * Data Configuration Wizard, the Data Sources Window was
 * used to construct the form. First, from the Data Sources window,
 * the coach name and sport were dragged over using Details. Then the full
 * Athlete table (under the Team table in the Data Sources window) was
 * dragged over. Then using the smart tag and properties window the
 * form and controls were formatted.
 * 
 * No program statements were added to this solution. All of the 
 * code was auto-generated.
 * 
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

namespace AthleticTeamApp
{
    public partial class FrmAthleticApp : Form
    {
        public FrmAthleticApp()
        {
            InitializeComponent();
        }

        private void teamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teamDataSet.Athlete' table. You can move, or remove it, as needed.
            this.athleteTableAdapter.Fill(this.teamDataSet.Athlete);
            // TODO: This line of code loads data into the 'teamDataSet.Team' table. You can move, or remove it, as needed.
            this.teamTableAdapter.Fill(this.teamDataSet.Team);
        }
    }
}
