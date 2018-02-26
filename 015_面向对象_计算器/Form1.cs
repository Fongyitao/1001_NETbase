using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_面向对象_计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCaoZuoFu.SelectedIndex = 0;
        }

        private void btnJiSuan_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Num1 = Convert.ToDouble(txtNum1.Text.Trim());
            calc.Num2 = Convert.ToDouble(txtNum2.Text.Trim());

            switch (cboCaoZuoFu.Text.Trim())
            {
                case "+":
                    lblResult.Text = calc.Add().ToString();
                    break;
                case "-":
                    lblResult.Text = calc.Sub().ToString();
                    break;
                case "*":
                    lblResult.Text = calc.Mult().ToString();
                    break;
                case "/":
                    lblResult.Text = calc.Division().ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
