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
    public partial class FizzBuzz : Form
    {
        junkyardForm JunkyardHome;
        public FizzBuzz(junkyardForm junkForm)
        {
            InitializeComponent();
            JunkyardHome = junkForm;
        }

        private void fizzbuzzBtn_Click(object sender, EventArgs e)
        {
            int userInput = Convert.ToInt16(inputTextBox.Text);
            displayListBox.Items.Clear();
            for (int i = 1; i < userInput; i++)
            {
                //x3 = Fizz, x5 = Buzz, x3 & x5 = FizzBuzz
                if (i % 5 == 0 && i % 3 == 0)
                {
                    displayListBox.Items.Add("(" + i + ") FizzBuzz!");
                } else if (i % 5 == 0)
                {
                    displayListBox.Items.Add("(" + i + ") Buzz");
                } else if (i % 3 == 0)
                {
                    displayListBox.Items.Add("(" + i + ") Fizz");
                } else
                {
                    displayListBox.Items.Add(i);
                }
            }
        }
    }
}
