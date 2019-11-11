using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int sum = 0;
        string newNr = "";

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Välkommen till Simple Calkulator!");
        }

        private void Summarize()
        {
            if (newNr != "")
            {
                sum = sum + Convert.ToInt32(newNr);
                newNr = "";
                textBox1.Text = Convert.ToString(sum);
            }
        }

        private void AddDigit(string nr)
        {
            textBox1.AppendText(nr);
            newNr += nr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Summarize();
            textBox1.Text = sum + "+";
        }

        private void buttonSummarize_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            sum = 0;
            newNr = "";
            textBox1.Text = "";
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void omProgammetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
