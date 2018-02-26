using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_索引器
{
    class ItcastClass
    {
        //编写一个类ItcastClass该类中有一个字段_names,数据类型为字符串数组,长度为5并且有5个默认的值;要求:为ItcastClass类编写一个索引器,要求该索引器要能通过下标来访问_name中的内容.
        private string[] _names = new string[5] { "张三","李四","王五","赵二","田七"};
        public int Count
        {
            get
            {
                return _names.Length;
            }
        }

        public string[] Names { get => _names; set => _names = value; }
        
        //索引器其实就是一个特殊属性，常规情况下索引器其实是一个名叫Item的属性
        public string this[int index]
        {
            set { _names[index] = value; }
            get
            {
                if (index<0 || index >= Count)
                {
                    throw new ArgumentException();
                }
                else
                {
                    return _names[index];
                }
            }
        }
    }
}
