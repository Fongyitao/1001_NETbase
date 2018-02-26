using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_猜拳游戏
{
    class Judge
    {
        int PlayerNum, Cpunum;
        string str;
        public int PlayerNum1 { get => PlayerNum; set => PlayerNum = value; }
        public int Cpunum1 { get => Cpunum; set => Cpunum = value; }
        public string Str { get => str; set => str = value; }


        //玩家赢：石头-剪刀=-1，剪刀-布=-1，布-石头=2
        //电脑赢：石头-布=-2，剪刀-石头=1，布-剪刀=1
        public string Jud()
        {
            switch (PlayerNum1-Cpunum1)
            {
                case -1:
                case 2:
                    Str = "You Win!";
                    break;
                case 1:
                case -2:
                    Str = "You Loser!";
                    break;
                default:
                    break;
            }
            return Str;
        }
    }
}
