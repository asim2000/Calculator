using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        double say1, say2, netice;
        string op;
        void method(string oprt)
        {
            if (textBox1.Text != "")
            {

                num2.Text = oprt;
                num1.Text = textBox1.Text;
                //say1 = Convert.ToDouble(textBox1.Text);
                label1.Text = num1.Text + " " + oprt;
                textBox1.Text = "";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "0";

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            //label1.Text = "";
            //textBox1.Text = "0";
            if (textBox1.Text!="") {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.IndexOf('.') < 1 && textBox1.Text != "")
            {
                textBox1.Text += ".";
            }
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            method("+");
        }

        protected void Unnamed16_Click(object sender, EventArgs e)
        {
            method("-");
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }

            else
            {
                textBox1.Text += "1";
            }
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }

            else
            {
                textBox1.Text += "2";
            }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }

            else
            {
                textBox1.Text += "3";
            }
        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }

            else
            {
                textBox1.Text += "4";
            }
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }

            else
            {
                textBox1.Text += "5";
            }
        }

        protected void Unnamed11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }

            else
            {
                textBox1.Text += "6";
            }
        }

        protected void Unnamed13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }

            else
            {
                textBox1.Text += "7";
            }
        }

        protected void Unnamed14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }

            else
            {
                textBox1.Text += "8";
            }
        }

        protected void Unnamed15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }

            else
            {
                textBox1.Text += "9";
            }
        }

        protected void Unnamed17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('-') < 0 && textBox1.Text != "0" && textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");

            }
        }

        protected void Unnamed18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }

            else
            {
                textBox1.Text += "0";
            }
        }

        protected void Unnamed19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                say2 = Convert.ToDouble(textBox1.Text);
                say1 = Convert.ToDouble(num1.Text);
                op = num2.Text;
                switch (op)
                {
                    case "+":
                        netice = say1 + say2;
                        break;

                    case "-":
                        netice = say1 - say2;
                        break;

                    case "x":
                        netice = say1 * say2;
                        break;

                    case "/":
                        netice = say1 / say2;
                        break;

                }
                textBox1.Text = netice.ToString();
                textBox1.Text = "";
                label1.Text = say1.ToString() + " " + op + " " + say2.ToString() + " " + "=" + " " + netice.ToString();

            }
        }
      
        protected void Unnamed12_Click(object sender, EventArgs e)
        {
            method("x");
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            method("/");
        }
    }
}