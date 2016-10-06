using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string workshop;
            string location;
            int days = 0;
            int registrationFee = 0;
            int lodgingFee = 0;

            workshop = workshopListBox.SelectedItem.ToString();
            location = locationListBox.SelectedItem.ToString(); 

            if (workshop == "Handling Stress")
            {
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
                    lodgingFee = 225;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 225;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 225;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 225;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }           
            }
            else if (workshop == "Time Management")
            {
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
                    lodgingFee = 225;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 225;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 225;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 225;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }               
            }
            else if (workshop == "Supervision Skills")
            {
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
                    lodgingFee = 225;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 225;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 225;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 225;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }  
            }
            else if (workshop == "Negotiation")
            {
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
                    lodgingFee = 225;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 225;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 225;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 225;
                }
                else
                {
                    MessageBox.Show("Please select a location.");
                }       
            }
            else if (workshop == "How to Interview")
            {
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
                    lodgingFee = 225;
                }
                else if (location == "Orlando")
                {
                    lodgingFee = 225;
                }
                else if (location == "Phoenix")
                {
                    lodgingFee = 225;
                }
                else if (location == "Raleigh")
                {
                    lodgingFee = 225;
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
            registrationLabel.Text = ("$" + registrationFee).ToString();
            lodgingLabel.Text = ("$" + lodgingFee + " x " + days + " days" + " = " + "$" + (lodgingFee * days)).ToString();
            totalLabel.Text = ("$" + (registrationFee + (lodgingFee * days))).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
