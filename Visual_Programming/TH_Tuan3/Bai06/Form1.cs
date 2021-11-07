﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operator_ = false;
        bool pressed = false;
        bool dot_pressed = false;
        bool reset = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox.Text == "0" || operator_ || reset)
            {
                textBox.Clear();
            }
            if (textBox.Text.Length > 9)
                return;
            operator_ = false;
            reset = false;
            btn_dot.Enabled = true;
            btn_backspace.Enabled = true;

            textBox.Text = textBox.Text + b.Text;

        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            dot_pressed = true;
            Button b = (Button)sender;
            if (operator_)
            {
                textBox.Clear();
            }
            if (dot_pressed)
            {
                btn_dot.Enabled = false;
            }                
            
            operator_ = false;
            textBox.Text = textBox.Text + b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (pressed)
            {
                Calculate();
            }    

            operator_ = true;
            pressed = true;
            btn_dot.Enabled = false;

            try
            {
                value = Double.Parse(textBox.Text);
            }
            catch
            {
                return;
            }
            label.Text = textBox.Text + " " + operation;
            operation = b.Text;
        }

        private void equalation_Click(object sender, EventArgs e)
        {
            Calculate();
            label.Text = textBox.Text;
            pressed = false;
            reset = true;

            btn_backspace.Enabled = false;
            
        }

        void Calculate()
        {
            switch (operation)
            {
                case "+":
                    {
                        textBox.Text = Output(value + Double.Parse(textBox.Text));
                        break;
                    }
                case "-":
                    {
                        textBox.Text = Output(value - Double.Parse(textBox.Text));
                        break;
                    }
                case "*":
                    {
                        textBox.Text = Output(value * Double.Parse(textBox.Text));
                        break;
                    }
                case "/":
                    {
                        if (textBox.Text == "0")
                        {
                            textBox.Text = "Cannot divided by zero.";
                        }
                        else
                            textBox.Text = Output(value / Double.Parse(textBox.Text));
                        break;
                    }
            }

            operation = "";
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] == ',')
                {
                    btn_dot.Enabled = false;
                    break;
                }    
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset = true;

            btn_backspace.Enabled = false;
            if (textBox.Text == "0")
            {
                textBox.Text = "Cannot divided by zero.";
            }
            else
            {
                try
                {
                    textBox.Text = Output(1 / Double.Parse(textBox.Text));
                }
                catch
                { return; }
            }
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox.Text = Output(Double.Parse(textBox.Text) / 100);
            reset = true;
            btn_backspace.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox.Text[0] == '-')
            {
                textBox.Text = "Math ERROR.";
            }
            else
            {
                textBox.Text = Output(Math.Sqrt(Double.Parse(textBox.Text)));
            }    
        }

        private void btn_resetall_Click(object sender, EventArgs e)
        {
            dot_pressed = true;
            label.Text = "";
            textBox.Text = "0";
            value = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dot_pressed = true;
            label.Text = "";
            textBox.Text = "0";
            value = 0;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            if (textBox.Text.Length == 0)
                textBox.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                if (textBox.Text[0] != '-')
                    textBox.Text = textBox.Text.Insert(0, "-");
                else
                    textBox.Text = textBox.Text.Substring(1);
            }    
        }

        string Output(double a)
        {
            return Math.Round(a, 5).ToString();
        }
    }
}
