using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double result;                  // Output of conversion from the selectedFrom to the selectedTo box
            double userInput;               // Number that user wants to convert to different measurement
            string selectedDistanceFrom;    // Selection from the first list box
            string selectedDistanceTo;      // Selection from the second list box

            // Number that user entered into a double
            userInput = double.Parse(userInputTextBox.Text);

            // Checks to see if list box is selected
            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
            {
                // Obtain the distance that the user want from each list box
                selectedDistanceFrom = fromListBox.SelectedItem.ToString();
                selectedDistanceTo = toListBox.SelectedItem.ToString();

                // Checks for a match within the first list box then checks for match within second list box and return the correct response
                switch (selectedDistanceFrom)
                {
                    case "Inches":      // If first selection is inches
                        switch (selectedDistanceTo)     // Checks second selection here
                        {
                            case "Inches":
                                result = userInput * 1;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput / 12;
                                resultLabel.Text = result.ToString("n2");
                                break;
                            case "Yards":
                                result = userInput / 36;
                                resultLabel.Text = result.ToString("n2");
                                break;
                        }
                        break;
                    case "Feet":        // If first selection is feet
                        switch (selectedDistanceTo)     // Checks second selection here
                        {
                            case "Inches":
                                result = userInput * 12;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput * 1;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Yards":
                                result = userInput / 3;
                                resultLabel.Text = result.ToString("n2");
                                break;
                        }
                        break;
                    case "Yards":       // If first selection is yards
                        switch (selectedDistanceTo)     // Checks second selection here
                        {
                            case "Inches":
                                result = userInput * 36;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput * 3;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Yards":
                                result = userInput * 1;
                                resultLabel.Text = result.ToString();
                                break;
                        }
                        break;
                }
            }
            else            // Display if user did not select two options
            {
                MessageBox.Show("Please select two options.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
