using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BAD_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // OPEN BUTTON
        // When open button is click, a save file dialog is launched
        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                // Clears the listbox
                urbanCenterListBox.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {   // Read the txt file
                        urbanCenterListBox.Items.Add(line);
                    }
                }
            }
        }

        // SAVE BUTTON
        // When open button is click, an open file dialog is launched
        private void saveBtn_Click(object sender, EventArgs e)
        {
/////////////////////////////////
        }
        // EXIT BUTTON
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // When Exit button is clicked, form is closed
            this.Close();
        }

        // GENERATE REPORT BUTTON
        // Generates the report on click
        private void genReportBtn_Click(object sender, EventArgs e)
        {   // Counts number of items in the list box and show in Total Number of Urban Center textbox
            int numberOfUC = urbanCenterListBox.Items.Count;
            totalTextBox.Text = numberOfUC.ToString();
            // Add all the population to obtain total population
            int totalPopulation = 0;
            for (int i = 0; i < urbanCenterListBox.Items.Count; i++)
            {
                totalPopulation += Convert.ToInt32(urbanCenterListBox.Items[i].ToString().Split(',')[1]);
            }


            totalPopulationtextBox.Text = totalPopulation.ToString();
            // Calculate the average population
            int average = totalPopulation/numberOfUC;
            averageTextBox.Text = average.ToString();

            // Find the largest population & smallest
            string maxline;
            int maxCount = int.MinValue;
            foreach (object item in urbanCenterListBox.Items)
            {
                string itemString = item.ToString();
                Match match = Regex.Match(itemString, @"\d+");
                if (match.Success)
                {
                    int count = int.Parse(match.Value);
                    if (count > maxCount)
                    {
                        maxline = itemString;
                        maxCount = count;
                        largestPopTextBox.Text = maxline;
                    }
                }
            }
            string minline;
            int minCount = int.MinValue;
            foreach (object item in urbanCenterListBox.Items)
            {
                string itemString = item.ToString();
                Match match = Regex.Match(itemString, @"\d+");
                if (match.Success)
                {
                    int count = int.Parse(match.Value);
                    if (count < maxCount)
                    {
                        minline = itemString;
                        minCount = count;
                        smallestPopTextBox.Text = minline;
                    }
                }
            }

        }

        // When an item in the list box is selected, its name and population is shown in respective textboxes
        private void urbanCenterListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {   // Split items in list box from commas
            string[] splitLine = urbanCenterListBox.SelectedItem.ToString().Split(',');
            // Add the item's, urban center name to respective textbox
            // At index 0 as the first string is the population name
            nameTextBox.Text = splitLine[0];
            // Add the item's, population to respective textbox as a string
            populationTextBox.Text = splitLine[1];
            // Call method classification
            // Convert the population to int in order to use operators
            Classification(Convert.ToInt32(splitLine[1]));
        }

        // Declaring classification conditional statements
        private void Classification(int population)
        {   
            if (population > 50000)
            {
                classificationTextBox.Text = "City";
            }

            if (population >= 5000 && population <= 50000)
            {
                classificationTextBox.Text = "Town";
            }

            if (population < 5000)
            {
                classificationTextBox.Text = "Rural";
            }
        }

        // Navigate up and down items in the list box using the next & previous buttons
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (urbanCenterListBox.SelectedIndex > 0)
                urbanCenterListBox.SelectedIndex = urbanCenterListBox.SelectedIndex - 1;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (urbanCenterListBox.SelectedIndex != urbanCenterListBox.Items.Count - 1)
                urbanCenterListBox.SelectedIndex = urbanCenterListBox.SelectedIndex + 1;
        }

        // Button to remove an item from the listbox
        private void removeBtn_Click(object sender, EventArgs e)
        {
            {
 //////////////////////////////////////////////              
            }
        }

        // Button to add a new urban center
        // Enter name and population and textbox then press add
        private void addBtn_Click(object sender, EventArgs e)
        {
            urbanCenterListBox.Items.Add(nameTextBox.Text + ", " + populationTextBox.Text);
        }
    }
}