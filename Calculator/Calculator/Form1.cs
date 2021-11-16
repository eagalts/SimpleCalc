using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string A, B;
        int result;

        bool sum = false, mul = false, div = false, def = false;

        public Form1()
        {
            InitializeComponent();
            A = "";
            B = "";
        }

        void ADrp()
        {
            sum = false; mul = false; div = false; def = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            A = "";
            B = "";
            ADrp();
            result = 0;
            Box.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "0";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            A = Box.Text;
            if      (sum == true) result = Convert.ToInt32(A) + Convert.ToInt32(B);
            else if (def == true) result = Convert.ToInt32(B) - Convert.ToInt32(A);
            else if (mul == true) result = Convert.ToInt32(B) * Convert.ToInt32(A);
            else if (div == true) result = Convert.ToInt32(B) / Convert.ToInt32(A);

            Box.Text = Convert.ToString(result);
            A = "";
            B = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ADrp();
            sum = true;
            B = Box.Text;
            A = "0";
            Box.Text = A;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ADrp();
            def = true;
            B = Box.Text;
            A = "0";
            Box.Text = A;
        }

        public void buttondel_Click(object sender, EventArgs e)
        {
            StringBuilder T = new StringBuilder(Box.Text);
            T[T.Length - 1] = '\0';
            Box.Text = Convert.ToString(T);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ADrp();
            mul = true;
            B = Box.Text;
            A = "0";
            Box.Text = A;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ADrp();
            div = true;
            B = Box.Text;
            A = "0";
            Box.Text = A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Box.Text = Box.Text + "1";
        }
    }
}
