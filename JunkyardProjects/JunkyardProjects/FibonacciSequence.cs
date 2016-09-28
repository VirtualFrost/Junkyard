using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunkyardProjects
{
    public partial class FibonacciSequence : Form
    {
        junkyardForm JunkyardHome;
        public FibonacciSequence(junkyardForm junkForm)
        {
            InitializeComponent();
            JunkyardHome = junkForm;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Generate the Fibonacci sequence to the Nth number.
            //New number = number + newnumber;
            //0, 1, 1, 2, 3, 5, 8, 13, (1 + 2 = 3, 2 + 3 = 5)
            int a = 0;
            int b = 1;
            int userInput = Convert.ToInt16(inputTextBox.Text);

            displayListBox.Items.Clear();           //Clears the listbox when you do a new search

            for(int i = 0; i < userInput; i++)
            {
                int temp = a;                       //Defines temp as a
                a = b;                              //Variable a = b (a = 1 as b = 1)
                b = temp + b;                       //b = temp(which is a, a = 1) + b(1)
                displayListBox.Items.Add(a);
            }
        }
    }
}
