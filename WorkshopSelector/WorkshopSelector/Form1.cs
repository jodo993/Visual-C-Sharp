using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string workshop;        // Save workshop in this variable
            string location;        // Save location in this variable
            int days = 0;           // Initialize days to 0
            int registrationFee = 0;    // Initialize registration to 0
            int lodgingFee = 0;         // Initialize lodging to 0

            workshop = workshopListBox.SelectedItem.ToString();     // Obtain workshop from listbox
            location = locationListBox.SelectedItem.ToString();     // Obtain location from listbox

            if (workshop == "Handling Stress")      // Checks to see if handling stress is selected from first listbox
            {
                // Change days and registration to correct amount corresponding with the workshop
                days = 3;
                registrationFee = 1000;
                if (location == "Austin")
                {
                    lodgingFee = 150;
                }
                else if (location == "Chicago")
                {
                    lodgingFee = 225;
                }
                else if (location == "Dallas")
                {
                    lodgingFee = 175;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 300;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 175;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 150;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }
            }
            else if (workshop == "Time Management")     // Checks to see if time management is selected from first listbox
            {
                // Change days and registration to correct amount corresponding with the workshop
                days = 3;
                registrationFee = 800;
                if (location == "Austin")
                {
                    lodgingFee = 150;
                }
                else if (location == "Chicago")
                {
                    lodgingFee = 225;
                }
                else if (location == "Dallas")
                {
                    lodgingFee = 175;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 300;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 175;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 150;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }
            }
            else if (workshop == "Supervision Skills")      // Checks to see if supervision skills is selected from first listbox
            {
                // Change days and registration to correct amount corresponding with the workshop
                days = 3;
                registrationFee = 1500;
                if (location == "Austin")
                {
                    lodgingFee = 150;
                }
                else if (location == "Chicago")
                {
                    lodgingFee = 225;
                }
                else if (location == "Dallas")
                {
                    lodgingFee = 175;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 300;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 175;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 150;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }
            }
            else if (workshop == "Negotiation")     // Checks to see if neogiation is selected from first listbox
            {
                // Change days and registration to correct amount corresponding with the workshop
                days = 5;
                registrationFee = 1300;
                if (location == "Austin")
                {
                    lodgingFee = 150;
                }
                else if (location == "Chicago")
                {
                    lodgingFee = 225;
                }
                else if (location == "Dallas")
                {
                    lodgingFee = 175;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 300;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 175;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 150;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }
            }
            else if (workshop == "How to Interview")        // Checks to see if how to interview is selected from first listbox
            {
                // Change days and registration to correct amount corresponding with the workshop
                days = 1;
                registrationFee = 500;
                if (location == "Austin")
                {
                    lodgingFee = 150;
                }
                else if (location == "Chicago")
                {
                    lodgingFee = 225;
                }
                else if (location == "Dallas")
                {
                    lodgingFee = 175;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 300;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 175;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 150;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }
            }
            else
            {
                MessageBox.Show("Please select a workshop.");
            }

            // Display the result to corresponding labels
            registrationLabel.Text = ("$" + registrationFee).ToString();        // Show registration fee
            lodgingLabel.Text = ("$" + lodgingFee + " x " + days + " days" + " = " + "$" + (lodgingFee * days)).ToString();     // Show numbers of day and how much per day
            totalLabel.Text = ("$" + (registrationFee + (lodgingFee * days))).ToString();       // Show total amount
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
