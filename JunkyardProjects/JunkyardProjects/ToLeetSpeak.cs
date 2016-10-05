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
    public partial class ToLeetSpeak : Form
    {
        public ToLeetSpeak(junkyardForm junkForm)
        {
            InitializeComponent();
        }

        public static string ToLeet(string str)
        {
            Dictionary<string, string> leetLetters = new Dictionary<string, string>();

            leetLetters.Add("A", "@");
            leetLetters.Add("B", "8");
            leetLetters.Add("C", "(");
            leetLetters.Add("E", "3");
            leetLetters.Add("G", "6");
            leetLetters.Add("H", "#");
            leetLetters.Add("I", "!");
            leetLetters.Add("L", "1");
            leetLetters.Add("O", "0");
            leetLetters.Add("S", "$");
            leetLetters.Add("T", "7");
            leetLetters.Add("Z", "2");
            foreach (KeyValuePair<string, string> x in leetLetters)
            {
                str = str.Replace(x.Key, x.Value);
            }
            MessageBox.Show(str);
            return str;
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            string userInput = inputTextBox.Text;
            ToLeet(userInput);
        }
    }
}
