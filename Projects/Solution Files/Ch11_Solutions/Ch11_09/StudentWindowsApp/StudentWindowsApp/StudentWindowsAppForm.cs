/* StudentWindowsApp.cs
 * This class is used to test
 * the Student base class and
 * subclasses. After objects
 * are instantiated, the records are
 * displayed on a GUI.
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
using StudentNamespace;
using UndergraduateStudentNamespace;
using GraduateStudentNamespace;


namespace StudentWindowsApp
{
    public partial class StudentWindowsAppForm : Form
    {
        GraduateStudent[] grads;
        UndergraduateStudent[] underGrads;

        public StudentWindowsAppForm()
        {
            InitializeComponent();
        }

        private void StudentWindowsAppForm_Load(object sender, EventArgs e)
        {
            grads = new GraduateStudent[5];
            underGrads = new UndergraduateStudent[10];

            grads[0] = new GraduateStudent("Ann", "Abbott", "CS", "00023110", "B.A.", "University of Jax");
            grads[1] = new GraduateStudent("Ben", "Bennett", "Math", "00021970", "B.A.", "Oion University");
            grads[2] = new GraduateStudent("Chin", "Lettinga", "Biology", "00032110", "B.A.", "River College");
            grads[3] = new GraduateStudent("Dexter", "Musclewhite", "CS", "00021810", "B.A.", "University of Keens");
            grads[4] = new GraduateStudent("Lonna", "Yang", "CIS", "00028810", "B.S.", "University of Jax");

            underGrads[0] = new UndergraduateStudent("David", "Smith", "CS", "00118714", "Freshman");
            underGrads[1] = new UndergraduateStudent("Derrick", "Tree", "Math", "00123314", "Sophomore");
            underGrads[2] = new UndergraduateStudent("Dan", "Mann", "CS", "00712314", "Freshman");
            underGrads[3] = new UndergraduateStudent("Barbara", "French", "Math", "00194314", "Freshman");
            underGrads[4] = new UndergraduateStudent("Connie", "Long", "Math", "00111294", "Freshman");
            underGrads[5] = new UndergraduateStudent("Cherry", "Raintree", "CS", "00196414", "Sophomore");
            underGrads[6] = new UndergraduateStudent("Dedrick", "Schultz", "CS", "00821314", "Freshman");
            underGrads[7] = new UndergraduateStudent("Thomas", "Gilreath", "CS", "00962314", "Freshman");
            underGrads[8] = new UndergraduateStudent("Justin", "Justice", "CS", "00186864", "Sophomore");
            underGrads[9] = new UndergraduateStudent("Burt", "King", "CS", "00421314", "Freshman");
        }

        private void cmboTypeOfStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxStudents.Items.Clear();
            lstBxStudents.Visible = true;
            lblResult.Text = "";
            lblResultHeading.Visible = false;
            

            lblInstructions.Text = "Make selection from Below to see details about student.";
            if (cmboTypeOfStudents.SelectedIndex == 0)
            {
                foreach (UndergraduateStudent student in underGrads)
                {
                    lstBxStudents.Items.Add(student.Id);
                }
            }
            else
                if (cmboTypeOfStudents.SelectedIndex == 1)
                {
                    foreach (GraduateStudent student in grads)
                    {
                        lstBxStudents.Items.Add(student.Id);
                    }
                }
        }

        private void lstBxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultHeading.Visible = true;
            lblResult.Text = "";
            if (cmboTypeOfStudents.SelectedIndex == 0)
            {
                foreach (UndergraduateStudent student in underGrads)
                {
                    if (student.Id.Equals(lstBxStudents.SelectedItem))
                        lblResult.Text = student.ToString();
                }
            }
            else
                if (cmboTypeOfStudents.SelectedIndex == 1)
                {
                    foreach (GraduateStudent student in grads)
                    {
                        if (student.Id.Equals(lstBxStudents.SelectedItem))
                            lblResult.Text = student.ToString();
                    }
                }
        }
    }
}
