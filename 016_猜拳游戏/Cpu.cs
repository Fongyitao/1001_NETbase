using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_猜拳游戏
{
    class Cpu
    {
        private string _str;
        private int _num;
        public string Str { get => _str; set => _str = value; }
        public int Num { get => _num; set => _num = value; }
        public int ChuQuan()
        {
            Random r = new Random();
            int n =  r.Next(1,4);
            switch (n)
            {
                case 1:
                    Str = "石头";
                    break;
                case 2:
                    Str = "剪刀";
                    break;
                case 3:
                    Str = "布";
                    break;
                default:
                    break;
            }
            return n;

        }

    }
}
