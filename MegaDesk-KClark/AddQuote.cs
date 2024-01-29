using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_KClark
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = nameInput.Text;
                int width = Convert.ToInt32(widthInput.Value); // Potential source of FormatException
                int depth = Convert.ToInt32(depthInput.Value); // Potential source of FormatException
                int drawers = Convert.ToInt32(drawerInput.Value); // Potential source of FormatException
                string material = materialInput.SelectedItem.ToString(); // Potential source of NullReferenceException

                int rushDays = 0;
                if (rushInput.SelectedItem != null)
                {
                    switch (rushInput.SelectedItem.ToString())
                    {
                        case "7 days":
                            rushDays = 7;
                            break;
                        case "5 days":
                            rushDays = 5;
                            break;
                        case "3 days":
                            rushDays = 3;
                            break;
                    }
                }

                // Call method to calculate quote
                CalculateQuote(customerName, width, depth, drawers, material, rushDays);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for width, depth, and drawers.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a material.");
            }
            catch (Exception ex) // General exception catch to handle any other unforeseen exceptions
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }


        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown numWidth = sender as NumericUpDown;
            if (numWidth != null)
            {
                // Check if the value is within the valid range
                if (numWidth.Value < numWidth.Minimum || numWidth.Value > numWidth.Maximum)
                {
                    e.Cancel = true;
                    numWidth.Focus();
                    errorProvider.SetError(numWidth, $"Width must be between {numWidth.Minimum} and {numWidth.Maximum}.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(numWidth, string.Empty);
                }
            }

        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is a digit or a control character (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Handle the event, so the character is not entered into the control
            }
        }

        private void CalculateQuote(string customerName, int width, int depth, int drawers, string material, int rushDays)
        {
            // Pricing Constants
            const int basePrice = 200;
            const int pricePerSquareInch = 1;
            const int pricePerDrawer = 50;
            var materialPrices = new Dictionary<string, int>
            {
                ["laminate"] = 100,
                ["oak"] = 200,
                ["rosewood"] = 200,
                ["veneer"] = 300,
                ["pine"] = 250,
            };
            var rushOrderPrices = new Dictionary<int, int>
            {
                [7] = 50,
                [5] = 60,
                [3] = 70
            };

            // Calculate Costs
            int area = width * depth;
            int areaCost = area * pricePerSquareInch;
            int drawerCost = drawers * pricePerDrawer;
            int materialCost = materialPrices.TryGetValue(material, out int matCost) ? matCost : 0;
            int rushOrderCost = rushOrderPrices.TryGetValue(rushDays, out int rushCost) ? rushCost : 0;

            int totalCost = basePrice + areaCost + drawerCost + materialCost + rushOrderCost;

            // Display the Quote
            DisplayQuote(customerName, totalCost, width, depth, drawers, material, rushDays);
        }

        private void DisplayQuote(string customerName, int totalCost, int width, int depth, int drawers, string material, int rushDays)
        {
            // Using MessageBox
            MessageBox.Show($"Quote for {customerName}:\n" +
                            $"Total Cost: ${totalCost}\n" +
                            $"Size: {width}\" x {depth}\"\n" +
                            $"Drawers: {drawers}\n" +
                            $"Material: {material}\n" +
                            $"Rush Order: {rushDays} days");
        }

    }
}
