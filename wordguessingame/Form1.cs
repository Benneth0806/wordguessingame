using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wordguessingame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideWord();
        }
        public void hideWord()
        {
            string Hide = "sp??k??";
            label1.Text = Hide;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guessWord = "laptop";

            StringBuilder word = new StringBuilder(textBox1.Text);

            if (word.Equals(guessWord))
            {
                textBox1.Text = guessWord;
                MessageBox.Show("Correct Guess!" + "\n" + "The word is " + guessWord);
            }
            else
            {
                listBox1.Items.Add(word);
                MessageBox.Show("Wrong Guess, Try again!");
            }
        }
    }
}
