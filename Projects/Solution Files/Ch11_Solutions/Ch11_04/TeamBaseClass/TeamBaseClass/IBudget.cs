/* IBudget.cs
 * This interface forces teams that implement
 * it to include a method indicating how they
 * are budgetted.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBaseClass
{
    interface IBudget
    {
        // abstract method
        string ShowHowBudgeted();
    }
}
