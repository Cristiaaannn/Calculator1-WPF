using System;
using System.Windows.Forms;

namespace Calculator1_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Display.ResetText();
            firstnumberlabel.ResetText();
            operatorlabel.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button1.Text;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button2.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button4.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button7.Text;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button12.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button6.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button8.Text;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button11.Text;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + this.button10.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.operatorlabel.Text = this.button5.Text;
            if (this.Display.Text != "")
            {
                this.firstnumberlabel.Text = Display.Text;
            }
            Display.ResetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.operatorlabel.Text = this.button9.Text;
            if (this.Display.Text != "")
            {
                this.firstnumberlabel.Text = Display.Text;
            }
            Display.ResetText();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.operatorlabel.Text = this.button13.Text;
            if (this.Display.Text != "")
            {
                this.firstnumberlabel.Text = Display.Text;
            }
            Display.ResetText();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.operatorlabel.Text = this.button20.Text;
            if (this.Display.Text != "")
            {
                this.firstnumberlabel.Text = Display.Text;
            }
            Display.ResetText();
        }

        private void firstnumberlabel_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double fn, sn;
            double.TryParse(this.firstnumberlabel.Text, out fn);
            double.TryParse(this.Display.Text, out sn);
            double r = 0;
            if (this.operatorlabel.Text == "+")
            {
                r = fn + sn;

            }
            if (this.operatorlabel.Text == "-")
            {
                r = fn - sn;

            }
            if (this.operatorlabel.Text == "X")
            {
                r = fn * sn;

            }
            if (this.operatorlabel.Text == "÷")
            {
                r = fn / sn;

            }
            this.Display.Text = r.ToString();
            this.firstnumberlabel.ResetText();
            this.operatorlabel.ResetText();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Display.Text = this.Display.Text + ".";
        }
    }
}
