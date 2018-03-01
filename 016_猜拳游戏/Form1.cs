using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_猜拳游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Player p = new Player();
            p.Str = btn.Text;
            int pi = p.ChuQuan();
            lblPlayer.Text = p.Str;

            Cpu cpu = new Cpu();
            int ci = cpu.ChuQuan();
            lblCpu.Text = cpu.Str;

            Judge j = new Judge();
            j.PlayerNum1 = pi;
            j.Cpunum1 = ci;
            lblResult.Text = j.Jud();
        }
    }
}
