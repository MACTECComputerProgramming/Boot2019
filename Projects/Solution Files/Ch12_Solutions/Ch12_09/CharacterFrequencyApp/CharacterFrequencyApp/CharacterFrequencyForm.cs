/*CharacterFrequencyApp.cs
 * Allows the user to input a paragraph and counts 
 * all the nonspace and nonreturn characters within
 * the paragraph. The program displays a table in 
 * ascending order showing the count of each letter.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterFrequencyApp
{
    public partial class FrmCounter : Form
    {
        public FrmCounter()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            String input;
            try
            {
                lstBxResults.Items.Clear();
                input = txtBxInput.Text;
                char[] paragraph = new char[input.Length];
                int[] amount = new int[input.Length];
                int max = 0;
                bool seen = false;

                input.ToCharArray();
                 
                for (int i = 0; i < paragraph.Length; i++)
                {
                    if (input[i].ToString() != " " && input[i].ToString() != "\n")
                    {
                        for (int j = 0; j <= max; j++)
                        {
                            if (paragraph[j] == input[i])
                            {
                                amount[j]++;
                                seen = true;
                            }
                        }
                        if (seen == false)
                        {
                            paragraph[max] = input[i];
                            amount[max] = 1;
                            max++;
                        }
                        seen = false;
                    }
                }

                for (int i = 0; i < max; i++)
                {
                    lstBxResults.Items.Add((paragraph[i] + " \t " + amount[i]).ToString());
                }
            }
            catch(Exception c)
            { 
                MessageBox.Show(c.Message, "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstBxResults.Items.Clear();
            txtBxInput.Text = " ";
            txtBxInput.Focus();
        }
    }
}
