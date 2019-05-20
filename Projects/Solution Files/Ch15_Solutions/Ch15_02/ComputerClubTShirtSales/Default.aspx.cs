// ComputerClubTShirtSales    Default.aspx
// This application allows users to enter their
// first and last names, phone number, and email address.
// They select a size (S,M, L, XL, and XXL) and quantity.
// From that, an order is placed. The output shown includes
// the name of the customer and the calculated total cost
// for the T-Shirts including tax. 


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
        txtFirst.Focus();
    }

    protected void btnProcess_Click(object sender, EventArgs e)
    {
        const double xLargePrice = 30.00;
        const double price = 26.00;
        const double taxPercentage = 0.07;

        double total = 0;
        if (ddListSize.SelectedIndex == 4)  //  Could also write if (ddListSize.SelectedValue.Equals("XX-Large")
            total = xLargePrice * int.Parse(txtQty.Text);
        else
            total = price * int.Parse(txtQty.Text);
        total += total * taxPercentage;

        lblResult.Text = "Selections made for " +
            txtFirst.Text + " " + txtLast.Text + 
            " ---- Size: " + ddListSize.SelectedValue + " - (Qty) " +
            txtQty.Text;
        lblTotal.Text = "Total cost, including tax, " +
            total.ToString("c");
    }
}