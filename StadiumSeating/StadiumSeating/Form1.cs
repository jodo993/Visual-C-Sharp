using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int ticketA = 0;            // Initialize number of ticket A sold
            int ticketB = 0;            // Initialize number of ticket B sold
            int ticketC = 0;            // Initialize number of ticket C sold
            int total = 0;              // Initialize total variable to 0
            const int MONEY_A = 15;     // Cost of ticket A
            const int MONEY_B = 12;     // Cost of ticket B
            const int MONEY_C = 9;      // Cost of ticket C

            // Record the total ticket for each class section and convert to integer
            ticketA = int.Parse(ticketSoldClassATextBox.Text);
            ticketB = int.Parse(ticketSoldClassBTextBox.Text);
            ticketC = int.Parse(ticketSoldClassCTextBox.Text);

            // Calculate the total for each class seat
            int moneyAtotal = ticketA * MONEY_A;
            int moneyBtotal = ticketB * MONEY_B;
            int moneyCtotal = ticketC * MONEY_C;

            // Calculate the total
            total = moneyAtotal + moneyBtotal + moneyCtotal;

            // Display total to corresponding labels
            revenueGeneratedClassA.Text = moneyAtotal.ToString("C");
            revenueGeneratedClassB.Text = moneyBtotal.ToString("C");
            revenueGeneratedClassC.Text = moneyCtotal.ToString("C");
            revenueGeneratedTotal.Text = total.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset the values of the text box to nothing
            ticketSoldClassATextBox.Text = "";
            ticketSoldClassBTextBox.Text = "";
            ticketSoldClassCTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
