// Programmer: Meredith Odell
// Date: 10/16/2019
// Project: Odell_2
// Description: Meredith Individual Assignment #2
// !Note courses checkboxes must be checked from the bottom up, that may be an
// issue with how I wrote the code.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odell_2
{
    public partial class languageArtsInstituteEnrollmentApplicationForm : Form
    {
        // Declare class-level constants for later use in the program
        private const decimal IN_STATE_PRICE = 59.00m;
        private const decimal OUT_OF_STATE_PRICE = 109.00m;
        private const decimal STARTING_PRICE = 0.00m;
        private const decimal STARTING_COURSE_NUMBER = 0;

        public languageArtsInstituteEnrollmentApplicationForm()
        {
            InitializeComponent();
        }

        // Execute when the InStateRadioButton is checked
        private void InStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pricePerCourseLabel.Text = IN_STATE_PRICE.ToString("c");
        }

        // Execute when the OutOfStateRadioButton is checked
        private void OutOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pricePerCourseLabel.Text = OUT_OF_STATE_PRICE.ToString("c");
        }

        // Execute when form loads at program startup
        private void LanguageArtsInstituteEnrollmentApplicationForm_Load_1(object sender, EventArgs e)
        {
            // Assign the tuition price values to the total label on the form
            pricePerCourseLabel.Text = STARTING_PRICE.ToString("c");
            numberOfCoursesLabel.Text = STARTING_COURSE_NUMBER.ToString("n0");

        }

        // Handle quit button's click event
        // Closes the form, ending the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handle clear button's click event
        // Clear all data entry and reset form to startup appearance
        private void ClearButton_Click(object sender, EventArgs e)
        {
            fallTermRadioButton.Checked = true;
            springTermRadioButton.Checked = false;
            termYearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            inStateRadioButton.Checked = true;
            outOfStateRadioButton.Checked = false;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            masterCardRadioButton.Checked = true;
            visaRadioButton.Checked = false;
            cardNumberMaskedTextBox.Text = "";
            expirationDateMaskedTextBox.Text = "";
            numberOfCoursesLabel.Text = STARTING_COURSE_NUMBER.ToString("n0");
            priceOfCoursesLabel.Text = "";
            pricePerCourseLabel.Text = STARTING_PRICE.ToString("c");
            coursesListBox.Items.Clear();

            // Sends the focus back to the first data entry on the form
            fallTermRadioButton.Focus();
        }

        // Sends the focus to the saveButton after the user is finished entering inputs
        private void ExpirationDateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            saveButton.Focus();
        }

        // Display all information in a MessageBox 
        // Parse data to strings to be used in MessageBox
        // If-else statements for choices between radio buttons
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Declare and initialize local variables
            string fall;
            string spring;
            string season;
            string year;
            string instate;
            string outofstate;
            string status;
            string mastercard;
            string visa;
            string cardtype;
            string cardnumber;
            string expiration;
            string ID;
            string firstname;
            string lastname;
            string email;
            decimal numberofcourses;
            string totalprice;
            string currentprice;
            
            // Assign variables to following controls
            fall = "Fall";
            spring = "Spring";
            year = termYearComboBox.Text;
            instate = "In-State";
            outofstate = "Out-Of-State";
            mastercard = "MasterCard";
            visa = "Visa";
            cardnumber = cardNumberMaskedTextBox.Text;
            expiration = expirationDateMaskedTextBox.Text;
            ID = studentIDMaskedTextBox.Text;
            firstname = firstNameTextBox.Text;
            lastname = lastNameTextBox.Text;
            email = emailAddressTextBox.Text;
            numberofcourses = decimal.Parse(numberOfCoursesLabel.Text);
            totalprice = priceOfCoursesLabel.Text;
            currentprice = pricePerCourseLabel.Text;

            // If-else statement for choices between season radio buttons
            if (fallTermRadioButton.Checked == true)
            {
                season = fall;
            }
            else
            {
                season = spring;
            }

            // If-else statement for choices between residency status radio buttons
            if (inStateRadioButton.Checked == true)
            {
                status = instate;
            }
            else
            {
                status = outofstate;
            }

            // If-else statement for choices between payment type radio buttons
            if (masterCardRadioButton.Checked == true)
            {
                cardtype = mastercard;
            }
            else
            {
                cardtype = visa;
            }

            // Display all information in a messageBox if the parameters are met
            // Use if-else block to run corresponding messages depending on the outcome
            if (numberofcourses >= 1)
            {
                if (numberofcourses <= 3)
                {
                    // Displays the message, a caption, and a MessageBoxIcon in the MessageBox
                    MessageBox.Show("Registration Term: " + season + " " + year + Environment.NewLine
                        + "Student ID: " + ID + Environment.NewLine
                        + "Student Name: " + firstname + " " + lastname + Environment.NewLine
                        + "Email Address: " + email + Environment.NewLine
                        + "Residence Status: " + status + Environment.NewLine
                        + "Total Courses Purchased: " + numberofcourses + Environment.NewLine
                        + "Price Per Course: " + currentprice + Environment.NewLine
                        + "Total Order Price: " + totalprice + Environment.NewLine
                        + "Credit Card Type: " + cardtype + Environment.NewLine
                        + "Card Number: " + cardnumber + Environment.NewLine
                        + "Card Expiration Date: " + expiration,
                        "Information Summary",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("You may only choose one to three courses.");
                }

            }

            else
            {
                MessageBox.Show("You may only choose one to three courses.");
            }

        }

        // Handle frenchcheckbox's checkedchanged event
        private void FrenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            if (frenchCheckBox.Checked)
            {
                coursesListBox.Items.Add("Beginning French Course");
            }

            else if (germanCheckBox.Checked)
            {
                coursesListBox.Items.Add("Beginning German Course");
            }

            else if (italianCheckBox.Checked)
            {
                coursesListBox.Items.Add("Beginning Italian Course");
            }

            else if (russianCheckBox.Checked)
            {
                coursesListBox.Items.Add("Beginning Russian Course");
            }

            else
            {
                coursesListBox.Items.Add("Beginning Spanish Course");
            }    

            int selection = 0;
            {
                if (frenchCheckBox.Checked)
                {
                    selection++;
                }
                if (germanCheckBox.Checked)
                {
                    selection++;
                }
                if (italianCheckBox.Checked)
                {
                    selection++;
                }
                if (russianCheckBox.Checked)
                {
                    selection++;
                }
                if (spanishCheckBox.Checked)
                {
                    selection++;
                }

            }

            // Display the number of courses selected on the numberOfCoursesLabel
            numberOfCoursesLabel.Text = selection.ToString();

            // Displays the total price of the order
            // Perform calculations when the checkboxes are selected
            // Declare and initialize local variable
            decimal price;
            decimal courses;
            decimal order;

            // Parse strings from the pricePerCoursesLabel and numberOfCoursesLabel
            if (numberOfCoursesLabel.Text == "0")
            {
                courses = 0;
            }
            else if (numberOfCoursesLabel.Text == "1")
            {
                courses = 1;
            }
            else if (numberOfCoursesLabel.Text == "2")
            {
                courses = 2;
            }
            else
            {
                courses = 3;
            }

            if (pricePerCourseLabel.Text == "$109.00")
            {
                price = 109m;
            }
            else
            {
                price = 59m;
            }

            order = price * courses;

            // Display the string in the priceofCoursesLabel
            priceOfCoursesLabel.Text = order.ToString("c");

            if (selection ==4)
            {
                MessageBox.Show("You may only choose one to three courses.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                if (frenchCheckBox.Checked)
                {
                    frenchCheckBox.Checked = false;
                }
                if (germanCheckBox.Checked)
                {
                    germanCheckBox.Checked = false;
                }
                if (italianCheckBox.Checked)
                {
                    italianCheckBox.Checked = false;
                }
                if (russianCheckBox.Checked)
                {
                    russianCheckBox.Checked = false;
                }
                if (spanishCheckBox.Checked)
                {
                    spanishCheckBox.Checked = false;
                }

                coursesListBox.Items.Clear();

            }
        }

        // Handle germancheckbox's checkedchanged event
        private void GermanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        // Handle italiancheckbox's checkedchanged event
        private void ItalianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

       // Handle russiancheckbox's checkedchanged event 
        private void RussianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        // Handle spanishcheckbox's checkedchanged
        private void SpanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    } 
}
