using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)// to calculate the due date in days
        {
           
                    DateTime currentDate = DateTime.Now; // get current date, chcek system date 
                    DateTime futureDate = DateTime.Parse(txtFutureDate.Text); //futuredate data variable
                    TimeSpan tillDue = futureDate.Subtract(currentDate); //calculateion subtracting futuredate from current
                    int daysDue = tillDue.Days;  //setting variable to hols calculation

                    MessageBox.Show("Curent Date: \t" + currentDate.ToShortDateString() + "\n\n" +
                    "Future Date: \t" + futureDate.ToShortDateString() + "\n\n" +
                    "Days Until Due: \t" + daysDue, "Till Due Days"
                    );  //message to display window.
        }
                           
    private void btnCalculateAge_Click(object sender, System.EventArgs e) // to calculate the age
        {
           

            DateTime today = DateTime.Now;  // get current date, chcek system date 
            DateTime birthyear = DateTime.Parse(txtBirthDate.Text);  //birthdate data variable
            int age = today.Year - birthyear.Year;//calculateion subtracting birthdate from today

            MessageBox.Show("Todays date: \t" + today.ToLongDateString() + "\n\n"
                        + "Birth Year: \t" + birthyear.ToLongDateString() + "\n\n"
                        + "Your Age is: \t" + age, "Show Me My Age"); //message to display window.
        }
        private void btnExit_Click(object sender, System.EventArgs e) // to exit program
        {
            this.Close();
        }
    }
}
