/* CalculatorApp   Default.aspx
 * This application displays a
 * calculator which performs
 * basic arithmetic operations.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void btns_Click(object sender, EventArgs e)
    {
        if (sender == btnAdd || sender == btnMinus || sender == btnDivide
                || sender == btnMultiply || sender == btnMod)
        {
            txtBxOp.Text = ((Button)sender).Text;
        }
        else
            if (sender == btnEqual)
            {
               txtBxResult.Text = DoArithmetic().ToString("N2");
            }
            else
                if (txtBxOp.Text == "")
                    txtBxOp1.Text += ((Button)sender).Text;
                else
                    txtBxOp2.Text += ((Button)sender).Text;
    }

    protected double DoArithmetic( )
    {
        double val1 = double.Parse(txtBxOp1.Text);
        double val2 = double.Parse(txtBxOp2.Text);
        char operation = char.Parse(txtBxOp.Text);
        double result = 0;

        if (operation == '+')
            result = val1 + val2;
        else
            if (operation == '-')
                 result = val1 - val2;
            else
                if (operation == '/')
                    result = val1 / val2;
                else
                    if (operation == '*')
                        result = val1 * val2;
                    else
                        if (operation == '%')
                             result = val1 % val2;
        return result;
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtBxOp1.Text = "";
        txtBxOp2.Text = "";
        txtBxResult.Text = "";
        txtBxOp.Text = "";
    }
}