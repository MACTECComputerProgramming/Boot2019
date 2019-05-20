/*TicketProcessingForm.cs
 * This application tests
 * the Ticket class and it's subclasses.
 * Users can select an event, seat
 * and price for a ticket. Objects are 
 * instantiated using the values.
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

namespace TicketProcessingApp
{
    public partial class TicketProcessingForm : Form
    {
        private Play aPlay;
        private MusicalEvent aMusicalEvent;
        private Lecture aLecture;

        public TicketProcessingForm()
        {
            InitializeComponent();
        }

        private void cmboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeat.Visible = true;
            lblRow.Visible = true;
            cmboRow.Visible = true;
            cmboSeat.Visible = true;
            lblInstructions.Visible = true;

            if (cmboEvent.SelectedItem.ToString() == "Green Lecture")
            {
                aLecture = new Lecture();
                aLecture.EventType = "Lecture";
                aLecture.EventName = "Green Lecture";
                aLecture.EventLocation = "Fields Auditorium";
                aLecture.EventDateTime = "September 12, 2014";
                aLecture.LectureTopic = "Planning for Tomorrow";
            }
            else
                if (cmboEvent.SelectedItem.ToString() == "Lecture on Sustainability")
                {
                    aLecture = new Lecture();
                    aLecture.EventType = "Lecture";
                    aLecture.EventName = "Lecture on Sustainability";
                    aLecture.EventLocation = "Johnson Lab";
                    aLecture.EventDateTime = "May 1, 2014";
                    aLecture.LectureTopic = "Making Smart Decisions";
                }
                else
                    if (cmboEvent.SelectedItem.ToString() == "Yellow Raisin Men")
                    {
                        aPlay = new Play();
                        aPlay.EventType = "Play";
                        aPlay.EventName = "Yellow Men Play";
                        aPlay.EventLocation = "Usen Theatre";
                        aPlay.EventDateTime = "October 1, 2014";
                        aPlay.NumberOfActors = 47;
                    }
                    else
                        if (cmboEvent.SelectedItem.ToString() == "Strings Musical")
                        {
                            aMusicalEvent = new MusicalEvent();
                            aMusicalEvent.EventType = "Musical";
                            aMusicalEvent.EventName = "Strings Musical";
                            aMusicalEvent.EventLocation = "Usennder Theatre";
                            aMusicalEvent.EventDateTime = "June 19, 2014";
                            aMusicalEvent.PerformerName = "JnG's";
                        }


    
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (cmboEvent.SelectedItem.ToString() == "Green Lecture")
            {
                aLecture.Row = cmboRow.SelectedItem.ToString();
                aLecture.Seat = int.Parse(cmboSeat.SelectedItem.ToString());
                aLecture.TicketCost = double.Parse(cmboPrice.SelectedItem.ToString());
                MessageBox.Show(aLecture.ToString());

            }
            else
                if (cmboEvent.SelectedItem.ToString() == "Lecture on Sustainability")
                {
                    aLecture.Row = cmboRow.SelectedItem.ToString();
                    aLecture.Seat = int.Parse(cmboSeat.SelectedItem.ToString());
                    aLecture.TicketCost = double.Parse(cmboPrice.SelectedItem.ToString());
                    MessageBox.Show(aLecture.ToString());

                }
                else
                    if (cmboEvent.SelectedItem.ToString() == "Yellow Raisin Men")
                    {
                        aPlay.Row = cmboRow.SelectedItem.ToString();
                        aPlay.Seat = int.Parse(cmboSeat.SelectedItem.ToString());
                        aPlay.TicketCost = double.Parse(cmboPrice.SelectedItem.ToString());
                        MessageBox.Show(aPlay.ToString());

                    }
                    else
                        if (cmboEvent.SelectedItem.ToString() == "Strings Musical")
                        {
                            aMusicalEvent.Row = cmboRow.SelectedItem.ToString();
                            aMusicalEvent.Seat = int.Parse(cmboSeat.SelectedItem.ToString());
                            aMusicalEvent.TicketCost = double.Parse(cmboPrice.SelectedItem.ToString());
                            MessageBox.Show(aMusicalEvent.ToString());

                        }
        }

    }
}
