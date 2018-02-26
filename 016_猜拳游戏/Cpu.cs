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
            return r.Next(1, 3);
        }

    }
}
