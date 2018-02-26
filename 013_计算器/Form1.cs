using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_计算器
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
            double num1, num2;
            double.TryParse(txtNum1.Text.Trim(), out num1);
            double.TryParse(txtNum2.Text.Trim(), out num2);
            switch (cboCaoZuoFu.Text.Trim())
            {
                case "+":
                    lblResult.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    lblResult.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    lblResult.Text = Math.Round(num1 * num2,4).ToString();
                    break;
                case "/":
                    lblResult.Text = Math.Round(num1 / num2,4).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
