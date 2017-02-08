using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();

            guessLabel.Text = "Number of guesses: " + Form1.guessList.Count();

            for (int i = 0; i < Form1.guessList.Count(); i++)
            {
                countLabel.Text += Form1.guessList[i] + ", ";
            }

            Form1.guessList.Sort();

            sortedLabel.Text = "\nSorted Order: \n";

            for (int i = 0; i < Form1.guessList.Count(); i++)
            {
                sortedLabel.Text += Form1.guessList[i] + ", ";
            }


        }


    }
}
