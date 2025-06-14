using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SharanPranav_Assignment2_BAP
{

    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        // Field Variables Declaration
        public static int NoOfGroupDiscount = 0, NoOfBookings = 0, flag = 0;
        public static string Program = "";
        public static decimal NoOfSessions = 0m, OverallCost = 0m, OverallOptionalUpgradesCost = 0m, TotalCost = 0m, 
                              TotalOptionalUpgradeCost = 0m, NoOfParticipants = 0, OptionalUpgradeCost = 0m;

        // Constant Variables Declaration
        const string PROGRAM1 = "Circuit Training", PROGRAM2 = "Pilates", PROGRAM3 = "High-Intensity Interval Training",
             PROGRAM4 = "Aerobics", PROGRAM5 = "Fitness Boot Camp", PROGRAM6 = "Weigh Training",
             PROGRAM7 = "Agility", PROGRAM8 = "Yoga", PROGRAM9 = "Speed Training";

        const decimal PROGRAM1FEE = 25m, PROGRAM2FEE = 40m, PROGRAM3FEE = 25m, PROGRAM4FEE = 25m, PROGRAM5FEE = 20m,
              PROGRAM6FEE = 25m, PROGRAM7FEE = 50m, PROGRAM8FEE = 35m, PROGRAM9FEE = 35m;

        const decimal SESSION1 = 1m, SESSION2 = 3m, SESSION3 = 5m, SESSION4 = 7m, SESSION5 = 10m, SESSION6 = 12m;

        const decimal DISCOUNT1 = 0m, DISCOUNT2 = 0.05m, DISCOUNT3 = 0.10m, DISCOUNT4 = 0.15m, DISCOUNT5 = 0.20m, DISCOUNT6 = 0.30m;

        const decimal ONETOONETRAININGFEE = 25m, SMALLGROUPTRAININGFEE = 15m, MEDIUMGROUPTRAININGFEE = 5m;

        const decimal PERSONALISEDBOTTLEPRICE = 7.99m;

        //On Clicking the Display Button
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // Declaring the Local Variables
            int ProgramsIndex = 0, SessionsIndex = 0;
            decimal ProgramCost = 0m, Discount = 0m, PersonalisedBottleCost = 0m;

            //Using if else Condition for Exceptional handling in Programs Listbox
            if ((ProgramsListBox.SelectedIndex != -1))
            {
                //Using if else Condition for Exceptional handling in Sessions Listbox
                if ((SessionsListBox.SelectedIndex != -1))
                {
                    //Assigning the Values to Programs Index and Sessions Index
                    ProgramsIndex = ProgramsListBox.SelectedIndex;
                    SessionsIndex = SessionsListBox.SelectedIndex;

                    try
                    {
                        // Assigning Value to Number of Participants
                        NoOfParticipants = int.Parse(NumberOfParticipantsTextBox.Text);

                        // Using if else Condition for Error Handling in Number of Participants Textbox
                        if (NoOfParticipants > 0)
                        {
                            // Using Switch Statement for Items Selection in Programs Listbox
                            switch (ProgramsIndex)
                            {
                                case 0: Program = PROGRAM1; ProgramCost = PROGRAM1FEE; break;
                                case 1: Program = PROGRAM2; ProgramCost = PROGRAM2FEE; break;
                                case 2: Program = PROGRAM3; ProgramCost = PROGRAM3FEE; break;
                                case 3: Program = PROGRAM4; ProgramCost = PROGRAM4FEE; break;
                                case 4: Program = PROGRAM5; ProgramCost = PROGRAM5FEE; break;
                                case 5: Program = PROGRAM6; ProgramCost = PROGRAM6FEE; break;
                                case 6: Program = PROGRAM7; ProgramCost = PROGRAM7FEE; break;
                                case 7: Program = PROGRAM8; ProgramCost = PROGRAM8FEE; break;
                                case 8: Program = PROGRAM9; ProgramCost = PROGRAM9FEE; break;
                            }

                            //Using Switch Statement for Items Selection in Sessions Listbox
                            switch (SessionsIndex)
                            {
                                case 0: NoOfSessions = SESSION1; Discount = DISCOUNT1; break;
                                case 1: NoOfSessions = SESSION2; Discount = DISCOUNT2; break;
                                case 2: NoOfSessions = SESSION3; Discount = DISCOUNT3; break;
                                case 3: NoOfSessions = SESSION4; Discount = DISCOUNT4; break;
                                case 4: NoOfSessions = SESSION5; Discount = DISCOUNT5; break;
                                case 5: NoOfSessions = SESSION6; Discount = DISCOUNT6; break;
                            }

                            // Toggling the Visibility and Assigning Name to the Groupbox
                            NoUpgradesRadioButton.Visible = true;
                            OutputGroupBox.Visible = true;
                            OutputGroupBox.Text = "Booking Summary";

                            // Using if Condition for Optional Upgrades and Personalised Bottle Calculations
                            if (OnetoOneGroupRadioButton.Checked == true)
                            {
                                OptionalUpgradeCost = ONETOONETRAININGFEE;
                            }
                            if (SmallGroupRadioButton.Checked == true)
                            {
                                OptionalUpgradeCost = SMALLGROUPTRAININGFEE;
                            }
                            if (MediumGroupRadioButton.Checked == true)
                            {
                                OptionalUpgradeCost = MEDIUMGROUPTRAININGFEE;
                            }
                            if (NoUpgradesRadioButton.Checked == true)
                            {
                                OptionalUpgradeCost = 0m;
                            }
                            if (BottleCheckBox.Checked == true)
                            {
                                PersonalisedBottleCost = PERSONALISEDBOTTLEPRICE;
                            }

                            //Using if else Condition for Group Discount Calculation
                            if (NoOfParticipants >= 4 && OptionalUpgradeCost > 0m)
                            {
                                // Calculating the Total Cost of the Selections made with Group Discount
                                TotalCost = ((((ProgramCost + OptionalUpgradeCost) - (Discount * (ProgramCost + OptionalUpgradeCost)))
                                            * NoOfSessions) + PersonalisedBottleCost) * NoOfParticipants; 
                                TotalCost = TotalCost - (0.075m * TotalCost);
                                NoOfGroupDiscount++;
                            }
                            else
                            {
                                // Calculating the Total Cost of the Selections made without Group Discount
                                TotalCost = ((((ProgramCost + OptionalUpgradeCost) - (Discount * (ProgramCost + OptionalUpgradeCost)))
                                            * NoOfSessions) + PersonalisedBottleCost) * NoOfParticipants;
                            }

                            // Calculations for Total Optional Upgrades Revenue and Displaying the Details of Program Selected
                            TotalOptionalUpgradeCost = ((NoOfSessions * OptionalUpgradeCost) + PersonalisedBottleCost) * NoOfParticipants;
                            OutputLabel.Text = "Number of Participants:  " + NoOfParticipants + "\n\n" + "Name of the Program:  " + Program +
                                                "\n\n" + "Number of Sessions:  " + NoOfSessions + "\n\n" + "Cost of Upgrade:  " + 
                                                OptionalUpgradeCost.ToString("C") + "\n\n" + "Total Payment Value:  " + TotalCost.ToString("C");
                            flag = 1;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        // Displaying the Error Handling using a Label
                        NumberOfParticipantsTextBox.Clear();
                        ErrorLabel.Text = "Please Enter a Valid Positive Number";
                        ErrorLabel.Visible = true;
                        NumberOfParticipantsTextBox.Focus();
                    }                    
                }
                else
                {
                    MessageBox.Show("Please Select one of the Sessions", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select one of the Programs", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Toggling the Visibility
            BookButton.Enabled = true;
        }

        // On Clicking the Book Button
        private void BookButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Using if else Condition for Displaying the Discount Applied Message
            if(NoOfParticipants >= 4 && OptionalUpgradeCost > 0m)
            {
                result = MessageBox.Show( "Name of the Program:  " + Program + "\n" + "Number of Sessions:  " + NoOfSessions + "\n" + "Total Payment Value:  " + TotalCost.ToString("C") + "\n\n" + "Group Discount Applied!" + "\n\n" + "Do you want to Confirm your Booking?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                result = MessageBox.Show("Name of the Program:  " + Program + "\n" + "Number of Sessions:  " + NoOfSessions + "\n" + "Total Payment Value:  " + TotalCost.ToString("C") + "\n\n" + "Do you want to Confirm your Booking?", "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            
            // Using if condition for YES Selected from the Message Box
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Incrementing the Values for Summary Calculations
                NoOfBookings++;
                OverallCost += TotalCost;
                OverallOptionalUpgradesCost += TotalOptionalUpgradeCost;
                MessageBox.Show("Your Booking is Successful!", "Booking Successful" , MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Calling the Clear Button Click Function to Clear the Form
                this.ClearButton_Click(sender, e);

            }
        }

        // On clicking Summary Button
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Toggling the Visibility and Setting Enabled Property
            OutputLabel.Visible = true;
            OutputGroupBox.Visible = true;
            ProgramsListBox.Enabled = false;
            SessionsListBox.Enabled=false;
            NumberOfParticipantsTextBox.Enabled=false;
            OnetoOneGroupRadioButton.Enabled=false;
            SmallGroupRadioButton.Enabled = false;
            MediumGroupRadioButton.Enabled= false;
            NoUpgradesRadioButton.Enabled=false;
            BottleCheckBox.Enabled=false;           
            DisplayButton.Enabled = false;
            BookButton.Enabled = false;
            OutputGroupBox.Text = "Halo Fitness Summary";
            decimal TotalAverageRevenue = 0;

            // Total Average Revenue Calculation and if Condition for Exceptional Handling if Summary Button is Clicked in the Beginning
            if (NoOfBookings>0)
            {
                TotalAverageRevenue = OverallCost / NoOfBookings;
            }
            
            // Displaying the Company Summary Details
            OutputLabel.Text = "Number of Bookings:  " + NoOfBookings + "\n\n" + "Number of Group Discounts:  " + NoOfGroupDiscount 
                               + "\n\n" + "Total Bookings Revenue:  " + OverallCost.ToString("C") + "\n\n" + "Total Optional Upgrades Revenue:  " + 
                               OverallOptionalUpgradesCost.ToString("C") + "\n\n" + "Total Average Revenue:  " + TotalAverageRevenue.ToString("C");
        }

        // Enabling Dynamic Response for Number Of Participants TextBox
        private void NumberOfParticipantsTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for Programs ListBox
        private void ProgramsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for Sessions ListBox
        private void SessionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for Bottle CheckBox
        private void BottleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for One to One Group RadioButton
        private void OnetoOneGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for Small Group RadioButton
        private void SmallGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for Medium Group RadioButton
        private void MediumGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // Enabling Dynamic Response for No Upgrades RadioButton
        private void NoUpgradesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.DisplayButton_Click(sender, e);
            }
        }

        // On Clicking Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Creating and Displaying the New Form, Disposing the Old Form
            Welcome_Form form = new Welcome_Form();
            form.Show();
            this.Dispose(false);
            flag = 0;
        }
        // On Clicking Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closing the page
            this.Close();
        }

    }
   
}
