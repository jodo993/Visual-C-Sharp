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
            double result;
            string selectedDistanceFrom;
            string selectedDistanceTo;

            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1 && userInputTextBox > 0)
            {
                double userInput = double.Parse(userInputTextBox.Text);
                selectedDistanceFrom = fromListBox.SelectedItem.ToString();
                selectedDistanceTo = toListBox.SelectedItem.ToString();

                switch (selectedDistanceFrom)
                {
                    case "Inches":
                        switch (selectedDistanceTo)
                        {
                            case "Inches":
                                result = userInput * 1;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput / 12;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Yards":
                                result = userInput / 36;
                                resultLabel.Text = result.ToString();
                                break;
                        }
                        break;
                    case "Feet":
                        switch (selectedDistanceTo)
                        {
                            case "Inches":
                                result = userInput / 12;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput * 1;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Yards":
                                result = userInput / 3;
                                resultLabel.Text = result.ToString();
                                break;
                        }
                        break;
                    case "Yards":
                        switch (selectedDistanceTo)
                        {
                            case "Inches":
                                result = userInput * 36;
                                resultLabel.Text = result.ToString();
                                break;
                            case "Feet":
                                result = userInput * 12;
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
            else
            {
                MessageBox.Show("Please select two options.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
