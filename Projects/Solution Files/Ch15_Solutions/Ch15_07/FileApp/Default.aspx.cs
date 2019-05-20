/* FileApp     Default.aspx
 * This application enables users to store 
 * first name, last name, and email addresses
 * in a text file. Users are permitted to enter a
 * directory path for the location of stored data.  
 * A confirmation of what is written is displayed on the GUI
 */
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected StreamWriter fil;
    public string fileName;

    protected void Page_Load(object sender, System.EventArgs e)
    {
        txtBxFilePath.Focus();
        lblInstructions.Text = "Where do you want to store the file" +
            "(i.e. C:\\Temp)? Specify path where Example.txt file will be stored!";
    }

    protected void Page_Unload(object sender, System.EventArgs e)
    {
        try
        {
            if (IsPostBack)  // If it is not the first time the page is loaded
            {
                fil.Flush();
                fil.Close();
            }
        }
        catch (IOException exc)
        {
            lblMsg.Text = exc.Message;
        }
    }

    protected void ClearForm()
    {
        txtBxFirst.Text = "";
        txtBxLast.Text = "";
        txtBxEmail.Text = "";
        lblInstructions.Text = "File stored at: " + txtBxFilePath.Text + "\\Example.txt";
    }

    protected void btnStore_Click(object sender, System.EventArgs e)
    {
        try
        {
            fileName = txtBxFilePath.Text + "\\Example.txt";
            fil = new StreamWriter(fileName, true);
            fil.WriteLine(txtBxFirst.Text + "|" + txtBxLast.Text + "|" + txtBxEmail.Text);
            lblMsg.Text = txtBxFirst.Text + "|" + txtBxLast.Text + "|" + txtBxEmail.Text + " Stored";
            ClearForm();
            txtBxFirst.Focus();
        }
        catch (IOException exc)
        {
            lblMsg.Text = exc.Message;
        }
    }


    protected void btnCreateFile_Click(object sender, System.EventArgs e)
    {
        fileName = txtBxFilePath.Text + "\\Example.txt";
        fil = new StreamWriter(fileName);
        txtBxFilePath.Enabled = false;
        txtBxFirst.Enabled = true;
        txtBxLast.Enabled = true;
        txtBxEmail.Enabled = true;
        btnStore.Enabled = true;
        txtBxFirst.Focus();
    }
}