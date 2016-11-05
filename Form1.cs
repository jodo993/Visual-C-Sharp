using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoeAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Value-returning methods needed:
        // oilLubeCharges, flushCharges, miscCharges, otherCharges, taxCharges, totalCharges

        // Checks the oil and lube and assign a price to it if selected
        private double OilLubeCharges(out double oilLubeCost)
        {
            double oilChange = 26;      // Cost of oil change
            double lubeJob = 18;        // Cost of lube job

            // Determines how much to charge for oil and lube
            if (oilChangeCheckBox.Checked && lubeJobCheckBox.Checked)
                oilLubeCost = oilChange + lubeJob;
            else if (oilChangeCheckBox.Checked)
                oilLubeCost = oilChange;
            else if (lubeJobCheckBox.Checked)
                oilLubeCost = lubeJob;
            else
                oilLubeCost = 0;
            return oilLubeCost;
        }

        // Checks the flushes and assign a price to it if selected
        private double FlushCharges (out double flushCost)
        {
            double radiatorFlush = 30;          // Cost of radiator flush
            double transmissionFlush = 80;      // Cost of transmission flush

            // Determines how much to charge for flush cost
            if (radiatorFlushCheckBox.Checked && transmissionFlushCheckBox.Checked)
                flushCost = radiatorFlush + transmissionFlush;
            else if (radiatorFlushCheckBox.Checked)
                flushCost = radiatorFlush;
            else if (transmissionFlushCheckBox.Checked)
                flushCost = transmissionFlush;
            else
                flushCost = 0;
            return flushCost;
        }

        // Check the misc and assign a price to it if selected
        private double MiscCharges (out double miscCost)
        {
            double inspection = 15;         // Cost of inspection
            double replaceMuffler = 100;    // Cost to replace muffler
            double tireRotation = 20;       // Cost to rotate tires

            // Determines how much to charge for misc items
            if (inspectionCheckBox.Checked && replaceMufflerCheckBox.Checked && tireRotationCheckBox.Checked)
                miscCost = inspection + replaceMuffler + tireRotation;
            else if (inspectionCheckBox.Checked && replaceMufflerCheckBox.Checked)
                miscCost = inspection + replaceMuffler;
            else if (inspectionCheckBox.Checked && tireRotationCheckBox.Checked)
                miscCost = inspection + tireRotation;
            else if (replaceMufflerCheckBox.Checked && tireRotationCheckBox.Checked)
                miscCost = replaceMuffler + tireRotation;
            else if (inspectionCheckBox.Checked)
                miscCost = inspection;
            else if (replaceMufflerCheckBox.Checked)
                miscCost = replaceMuffler;
            else if (tireRotationCheckBox.Checked)
                miscCost = tireRotation;
            else
                miscCost = 0;
            return miscCost;
        }

        // Check the other and assign a price to it if selected
        private double OtherCharges ()
        {
            double parts;               // Cost of parts user entered
            double labor;               // Cost of labor user entered
            double partCost = 0;
            double laborCost = 0;

            // Convert string of parts/labor cost into double
            if (double.TryParse(partsTextBox.Text, out parts))
                partCost = parts;
            if (double.TryParse(laborTextBox.Text, out labor))
                laborCost = labor;
            return partCost + laborCost;
        }

        // Finds the tax cost for parts only
        private double TaxCharges (ref double otherCost)
        {
            // otherCost is partCost 
            double saleTax = 0.06;                  // Sale tax percentage
            double tax = otherCost * saleTax;       // Finding the tax
            return tax;
        }

        // Find cost of entire services, parts, and tax
        private double TotalCharges (ref double oilLubeCharge, ref double flushCharges, ref double miscCharges, ref double otherCharges, ref double taxCharges)
        {
            double totalCost;

            totalCost = oilLubeCharge + flushCharges + miscCharges + otherCharges + taxCharges;
            return totalCost;
        }

        // All void clears all boxes, reset program
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        private void ClearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }

        private void ClearFees()
        {
            serviceAndLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalFeeLabel.Text = "";
        }
           
        // Calls other methods
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold the cost of each charges
                double oilLubeCharges,
                       oilLubeCost,
                       flushCharges,
                       flushCost,
                       miscCharges,
                       miscCost,
                       otherCharges,
                       taxCharges,
                       totalCharges;

                double parts,
                       partCharge,
                       labor,
                       laborCharge;

                // Find the amount spent on parts in text box
                if (double.TryParse(partsTextBox.Text, out parts))
                    partCharge = parts;
                else
                    partCharge = 0;

                // Find the amount spent on labor in text box
                if (double.TryParse(laborTextBox.Text, out labor))
                    laborCharge = labor;
                else
                    laborCharge = 0;

                // Calling methods to find cost for respective sections
                oilLubeCharges = OilLubeCharges(out oilLubeCost);
                flushCharges = FlushCharges(out flushCost);
                miscCharges = MiscCharges(out miscCost);
                otherCharges = OtherCharges();
                taxCharges = TaxCharges(ref partCharge);
                totalCharges = TotalCharges(ref oilLubeCharges, ref flushCharges, ref miscCharges, ref otherCharges, ref taxCharges);

                // Display results
                serviceAndLaborLabel.Text = (oilLubeCharges + flushCharges + miscCharges + laborCharge).ToString("C");
                partsLabel.Text = partCharge.ToString("C");
                taxLabel.Text = taxCharges.ToString("C");
                totalFeeLabel.Text = totalCharges.ToString("C");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Calls other methods to clear the program boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        // Close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
