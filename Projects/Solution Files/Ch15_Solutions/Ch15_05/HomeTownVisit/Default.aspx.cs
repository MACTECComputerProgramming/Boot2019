/* HomeTownVisit    Default.aspx
 * This application creates a Web page to highlight 
 * the features of a hometown. The ASP.NET Empty Web 
 * Site template was selected. A Web Form and an Images folder
 * were added. Information was included 
 * about Williamsburg KY, Doyle's hometown.
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

    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        lblOutput.Text = "Population - 5,245; 91 Miles from Lexington KY; 54 miles from Knoxville TN";
    }
}