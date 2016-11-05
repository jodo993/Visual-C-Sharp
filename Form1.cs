using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int findBoyName(string nameOfBoy, string[] boyNames)
        {
            bool found = false;                             // Set found to false until/if name is found
            int i = 0;                                      // Start at sub of zero in array
            int position = -1;                              // Position determines which if statement in checkButton uses

            // Look for name with sequential search
            while (!found && i < boyNames.Length)           
            {
                if (nameOfBoy == boyNames[i])
                {
                    found = true;
                    position = i;
                }
                i++;
            }
            return position;
        }

        private int findGirlName(string nameOfGirl, string[] girlNames)
        {
            bool found = false;                             // Set found to false until/if name is found
            int i = 0;                                      // Start at sub of zero in array
            int position = -1;                              // Position determines which if statement in checkButton uses

            // Look for name with sequential search
            while (!found && i < girlNames.Length)
            {
                if (nameOfGirl == girlNames[i])
                {
                    found = true;
                    position = i;
                }
                i++;
            }
            return position;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an empty array with size of 200
                const int SIZE = 200;
                string[] boyNames = new string[SIZE];
                string[] girlNames = new string[SIZE];

                // User input of a boy name and a girl name
                string nameOfBoy;
                string nameOfGirl;

                // Retrieve a boy name and a girl name from the text box
                nameOfBoy = boyNameTextBox.Text;
                nameOfGirl = girlNameTextBox.Text;

                // Declaring streamreader variable
                StreamReader inputFileBoys;
                StreamReader inputFIleGirls;

                // Open text files
                inputFileBoys = File.OpenText("BoyNames.txt");
                inputFIleGirls = File.OpenText("GirlNames.txt");

                // Read boy names and put in list
                int indexBoy = 0;
                while (indexBoy < boyNames.Length && !inputFileBoys.EndOfStream)
                {
                    boyNames[indexBoy] = inputFileBoys.ReadLine();
                    indexBoy++;
                }

                // Read girl names and put in list
                int indexGirl = 0;
                while (indexGirl < girlNames.Length && !inputFIleGirls.EndOfStream)
                {
                    girlNames[indexGirl] = inputFIleGirls.ReadLine();
                    indexGirl++;
                }

                // Closes text file
                inputFileBoys.Close();
                inputFIleGirls.Close();

                // If both boy name and girl name are entered
                // Determines if both are popular or only one is popular and the other is not
                if (nameOfBoy != "" && nameOfGirl != "")
                {
                    if (findBoyName(nameOfBoy, boyNames) != -1 && findGirlName(nameOfGirl, girlNames) != -1)
                    {
                        resultLabel.Text = "Both " + nameOfBoy + " and " + nameOfGirl + " are among most popular.";
                    }
                    else if (findBoyName(nameOfBoy, boyNames) != -1 && findGirlName(nameOfGirl, girlNames) == -1)
                    {
                        resultLabel.Text = nameOfBoy + " is among most popular, but " + nameOfGirl + " is not.";
                    }
                    else if (findGirlName(nameOfGirl, girlNames) != -1 && findBoyName(nameOfBoy, boyNames) == -1)
                    {
                        resultLabel.Text = nameOfGirl + " is among most popular, but " + nameOfBoy + " is not.";
                    }
                    else
                    {
                        resultLabel.Text = "Both are not among most popular.";
                    }
                } // If boy name is entered but girl name is not
                else if (nameOfBoy != "" && nameOfGirl == "")
                {
                    if (findBoyName(nameOfBoy, boyNames) != -1)
                    {
                        resultLabel.Text = nameOfBoy + " is among most popular.";
                    }
                    else
                    {
                        resultLabel.Text = nameOfBoy + " is not among most popular.";
                    }

                } // If girl name is entered but boy name is not
                else if (nameOfGirl != "" & nameOfBoy == "")
                {
                    if (findGirlName(nameOfGirl, girlNames) != -1)
                    {
                        resultLabel.Text = nameOfGirl + " is among most popular.";
                    }
                    else
                    {
                        resultLabel.Text = nameOfGirl + " is not among most popular.";
                    }
                }
                else // If no names were entered
                {
                    resultLabel.Text = "Nothing was entered.";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            boyNameTextBox.Text = "";
            girlNameTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
