/* WeightConverter.cs
 * The Weight Converter class
 * converts weights between Grams and 
 * Kilograms to Pounds and Ounces and
 * visa versa. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightConverterApp
{
    class WeightConverter
    {
        private double numToConvert;
        private double weight;
        private string originalUnitOfMeasurement;
        private string newUnitOfMeasurement;

        public WeightConverter()
        {
        }

        public WeightConverter(double num)
        {
            if (num < 0)
                throw new Exception("Error: negative number");
            else
                weight = num;
        }

        public WeightConverter(double num, String unit)
        {
            numToConvert = num;
            originalUnitOfMeasurement = unit;
            if (numToConvert < 0)
                throw new Exception("Error: negative number");
            else
            {

                if (originalUnitOfMeasurement == "Kilograms")
                    weight = numToConvert * 1000;
                else
                    if (originalUnitOfMeasurement == "Pounds")
                        weight = 453.6 * numToConvert;
                    else
                        if (originalUnitOfMeasurement == "Ounces")
                            weight = 28.35 * numToConvert;
                        else
                            if (originalUnitOfMeasurement == "Grams")
                                weight = numToConvert;
                            else
                                throw new Exception("Error incorrect unit");
            }
        }

        public string OriginalUnitOfMeasurement
        {
            get { return originalUnitOfMeasurement; }
            set { originalUnitOfMeasurement = value; }
        }

        public double NumToConvert
        {
            get { return numToConvert; }
            set { numToConvert = value; }
        }

        public string NewUnitOfMeasurement
        {
            get { return newUnitOfMeasurement; }
            set { newUnitOfMeasurement = value; }
        }

        public double ToKilo()
        {
            return (weight / 1000);
        }

        public double ToPounds()
        {
            return (weight / 453.6);
        }

        public double ToOunces()
        {
            return (weight / 28.35);

        }

        public double ToGrams()
        {
            return (weight);
        }


        public double Weight
        {
            set
            {
                weight = value;
            }
        }

        public override string ToString()
        {   
            double newValue = 0;

            switch (newUnitOfMeasurement)
            {
                case "Kilograms" : 
                    newValue = ToKilo();
                    break;
                case  "Pounds" : 
                    newValue = ToPounds();
                    break;
                case "Ounces" :
                    newValue = ToOunces();
                    break;
                case  "Grams" :
                    newValue = ToGrams();
                    break;
               
            }
            return originalUnitOfMeasurement +
                "\n" + newValue;
        }
    }
}
