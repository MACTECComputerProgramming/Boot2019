// ShowExamDate
// This Web application displays a calendar
// with the current date selected. Users
// are able to use it to select the date of
// of their next exam. That date with a
// message is displayed. If a date is 
// selected in the past, a message is printed.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Calendar1.SelectedDate = DateTime.Today;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        if (this.Calendar1.SelectedDate.DayOfYear >= DateTime.Today.DayOfYear)
        {
            this.lblResult.Text = "The date you have selected is " +
                this.Calendar1.SelectedDate.DayOfWeek.ToString() + ", " +
                this.Calendar1.SelectedDate.Date.ToShortDateString() +
                ".\n\n\n***Prepare in order to do well!";
            this.lblResult.Visible = true;
        }
        else
            this.lblResult.Text = "Select an upcoming exam date - in the future."; 
    }
}