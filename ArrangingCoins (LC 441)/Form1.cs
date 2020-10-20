using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrangingCoins__LC_441_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            int userNum;
            int count = 1;
            int row = 1;

            if (int.TryParse(numTextBox.Text, out userNum))
            {
                while (userNum - row > row)
                {
                    userNum -= 1;
                    count++;
                    row++;
                }
                
                MessageBox.Show("The number of complete rows = " + count);
                


            }
            else
            {
                MessageBox.Show("Please enter a number.");
            }
        }
    }
}
