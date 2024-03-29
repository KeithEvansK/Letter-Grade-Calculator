/*
 * Keith Evans
 * Exercise 2 - Grade Form Application
 * 2/4/2024
 * CSCI-1630
 * Dr. I
 * WEB-82771
 * 
 * This application converts an input grade percentage to a letter grade.
 * 
 */

using System.Diagnostics.Metrics;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Save the users grade input.
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);



            // Calculate the input grade to a letter grade.
            string letterGrade = "";
            if (numberGrade >= 88)
            {
                letterGrade = "A";


            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";

            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";

            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";

            }
            else
            {
                letterGrade = "F";
            }

            // Display the grade.
            txtLetterGrade.Text = letterGrade;

            // Refocus the curser to the Number Grade text box.
            txtNumberGrade.Focus();





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program.
            this.Close();
        }
    }
}
