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

        string currentWord = "waar";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string labelText = "";
            label1.Text = "";
            for (int i = 0; i < currentWord.Length; i++)
            {
                labelText += "_ ";
            }
            label1.Text = labelText.Substring(0, labelText.Length - 1);
            
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < currentWord.Length; i++)
            {
                if(currentWord[i].ToString().ToLower() == "a")
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }


    }
}
