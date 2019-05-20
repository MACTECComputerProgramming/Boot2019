/* PresentationGUI.cs
 * This class instantiates objects of
 * the tennis and rowing class when the
 * form is loaded. Details about each
 * team are displayed when tabs for the
 * team are selected. 
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
using TeamBaseClass;

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        Tennis tennisTeam;
        Rowing rowingTeam;
      
        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            string [ ] singles = new string [ ] {"Amanda Johns", "Susan Lloyd", "Brenda Howard", "Rebecca King", "Samantha Wung", "Lin Choo"};
            string [ ] doubles = new string [ ] {"Johns/Lloyd", "Howard/King", "Messer/Lettinga"};
            tennisTeam = new Tennis("Tennis", "Chin", singles, doubles);
            rowingTeam = new Rowing("Rowing", "Stigal", "4-6 p.m.", "John Wang");

            txtBxCoachTennis.Text = tennisTeam.PrimaryCoach;  // Retrieved from AthleticTeam class
            txtBxCoachRowing.Text = rowingTeam.PrimaryCoach;

            txtBxPlayers.Text = tennisTeam.GetSinglesPlayersNames();
            txtBxCountOfTennisPlayers.Text = tennisTeam.ReturnNumberOfPlayers().ToString();
            txtBxSwimTennis.Text = tennisTeam.GetSwimPoolAvailability();
            txtBxWeightTennis.Text = tennisTeam.GetWeightRoomAvailability();
            txtBxTennisFunded.Text = tennisTeam.ShowHowBudgetted();

            txtBxHeadCoxswain.Text = rowingTeam.HeadCoxswain;
            txtBxSeason.Text = rowingTeam.GetSeasonTimeSpan();
            txtBxSwimRowing.Text = rowingTeam.GetSwimPoolAvailability();
            txtBxWeightRowing.Text = rowingTeam.GetWeightRoomAvailability();
            txtBxRowingFunded.Text = rowingTeam.ShowHowBudgetted();
            txtBxBoatHouse.Text = rowingTeam.BoatHouseHours;
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tennisTeam.ToString(), "TJC University");
        }

        private void btnRowing_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rowingTeam.ToString(), "TJC University");
        }
    }
}
