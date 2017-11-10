using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentWord = "wow";
            string labelText = "";
            label1.Text = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                labelText += "_";
            }
            label1.Text = labelText.Substring(0, labelText.Length - 1);
            //load
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }
    }
}
