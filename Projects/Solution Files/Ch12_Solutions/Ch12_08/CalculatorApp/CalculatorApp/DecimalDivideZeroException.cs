using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class DecimalDivideZeroException : ApplicationException
    {
        public DecimalDivideZeroException()
            : base()
        {

        }

        public DecimalDivideZeroException(string message)
            : base(message)
        {
        }

        public DecimalDivideZeroException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
