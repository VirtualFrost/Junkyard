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
    public partial class junkyardForm : Form
    {
        public junkyardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FizzBuzz fizzbuzzForm = new FizzBuzz(this);
            fizzbuzzForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToLeetSpeak toLeetSpeakForm = new ToLeetSpeak(this);
            toLeetSpeakForm.Show();
        }
    }
}
