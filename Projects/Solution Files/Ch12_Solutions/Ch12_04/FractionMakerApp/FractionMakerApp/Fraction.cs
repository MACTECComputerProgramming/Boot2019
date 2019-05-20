/* Fraction.cs
 * This class has data members for
 * numerator and denominator. Methods
 * are included to produce a fraction
 * from those values. A method is
 * included to reduce the fraction.
 * Exception handling techniques are
 * part of the class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionMakerApp
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int denom)
        {
            try
            {
                numerator = num;
                denominator = denom;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                try
                {
                    numerator = value;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                try
                {
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }
            }
        }

        public double CalculateDecimalValue()
        {
            double val;
            try
            {
                if (denominator == 0)
                {
                    throw new Exception("Error: Divide by Zero");
                    val = 0;
                }
                else
                {
                    val = (double)numerator / denominator;
                }
            }
            catch (DivideByZeroException e)
            {
                val = 0;
                numerator = 0;
                denominator = 0;
                MessageBox.Show(e.Message, "Error");
            }

            return val;
        }

        public void Reduce()
        {
            int remainder,
                oldremainder,
                temp;

            if (numerator != 0)
            {
                if (denominator % numerator == 0)
                {
                    denominator = denominator / numerator;
                    numerator = 1;
                }
                else
                {       //Using Eulers Algoritm

                    remainder = denominator % numerator;
                    temp = numerator;
                    do
                    {
                        oldremainder = remainder;
                        remainder = temp % oldremainder;
                        temp = oldremainder;

                    } while (remainder > 0);

                    denominator = denominator / oldremainder;
                    numerator = numerator / oldremainder;
                }
            }


        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

    }
}