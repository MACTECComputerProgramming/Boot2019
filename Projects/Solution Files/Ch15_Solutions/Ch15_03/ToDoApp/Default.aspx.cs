/* ToDoApp     Default.aspx
 * This application enables users
 * to create their ToDo List. Items
 * are added to the list dynamically. 
 * Items can be removed from the list.
 */

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
        txtBxName.Focus();
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lstBoxToDo.Items.Add(txtBxItem.Text);
        txtBxItem.Text = "";
        txtBxItem.Focus();
    }

    protected void lstBoxToDo_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblOutput.Text = txtBxName.Text + ", " + lstBoxToDo.SelectedItem.Text +
            " removed from the list";
        lstBoxToDo.Items.Remove(lstBoxToDo.SelectedItem);
    }
}