using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Jonah Martin
 * Date: October 6, 2022
 * Description: The purpose of this form is to calculate simple multiplication problems as well as
 * to show a picture and a description of the topic (my favourite meal) using different buttons to
 * switch between photo and description. */

namespace MartinLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the purpose of the following code is to close the program using the Exit button.
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Dev Tools Homework 5");
            this.Close();
        }

        //the purpose of the following code is to show the image of spaghetti and to hide the label.
        private void btnPicture_Click(object sender, EventArgs e)
        {
            pictureBoxspaghetti.Show();
        }

        //the purpose of the following code is to hide the image
        private void btnHide_Click(object sender, EventArgs e)
        {
            pictureBoxspaghetti.Hide();
            lblFavouritemeal.Text = "My favourite meal";
        }

        /*The purpose of the following code is to clear the textboxes and the answer label as well as
         * to place the cursor in the first textbox.*/
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxnumber.Clear();
            textBoxmultiplier.Clear();
            textBoxnumber.Select();
            lblAnswer.Text = " ";
        }

        /*The purpose of the following code is to hide the picture and to show the data label and 
         * paragraphs about my topic which is spaghetti*/
        private void btnData_Click(object sender, EventArgs e)
        {
            pictureBoxspaghetti.Hide();
            string description = "My favourite meal";
            lblFavouritemeal.Text = description + "\n" + "My topic is: " + description + ". My favourite meal is spaghetti. It is a meal I" +
                " have always enjoyed eating as well as cooking. It is incredibly filling and, if you make it right, downright delicious. \n \n" +
                "There are many ingredients you can put into spaghetti. For me some of my favourites are onions, garlic, mushrooms, spinach, broccoli, \n" +
                " tomatoes, and bell peppers. \n \n There is also the matter of sauce. The sauce that you buy will determine much of the flavour." +
                " A brand that I like to buy is Classico, though, I think it would be interesting to try to make my own sauce.";

        }

        //the purpose of the following code is to display a message box with information about the picture.
        private void pictureBoxspaghetti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a picture of spaghetti.", "Jonah Martin");

        }

        //The purpose of the following code is to claculate and display an answer based on the two user inputs.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBoxnumber.Text);
            int multiplier = Convert.ToInt32(textBoxmultiplier.Text);
            int answer = number * multiplier;
            lblAnswer.Text = answer.ToString();
        }
    }
}
