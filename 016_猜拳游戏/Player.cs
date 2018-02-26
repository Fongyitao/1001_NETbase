using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_猜拳游戏
{
    class Player
    {
        string _str;
        int _num;
        public string Str { get => _str; set => _str = value; }
        public int Num { get => _num; set => _num = value; }

        public int ChuQuan()
        {
            switch (Str)
            {
                case "石头":
                    Num = 1;
                    break;
                case "剪刀":
                    Num= 2;
                    break;
                case "布":
                    Num= 3;
                    break;
                default:
                    break;
            }
            return Num;
        }
    }

}
