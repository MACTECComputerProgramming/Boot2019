//  FileOfRandomValues.cs
// This program stores 5 random numbers per line in a text file. 
// 10 different lines are stored.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StoreRandomNumbersApp
{
    class FileOfRandomValues
    {
        static void Main(string[] args)
        {
            Random generator;
            StreamWriter numberFile;
            String number = "";
            try
            {
                generator = new Random();
                numberFile = new StreamWriter("numbers.txt");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        number += generator.Next(1001).ToString() + " ";
                    }
                    numberFile.WriteLine(number);
                    number = "";
                }

                numberFile.Close();
                MessageBox.Show("Numbers stored!");
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
