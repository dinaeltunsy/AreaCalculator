using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shape
    {
        public string Shape_name;
        public string Shape_D;
        public int a_Side;
        public int b_Height;


        public string getData()
        {
            return this.Shape_name + ":" + this.Shape_D;
        }
    }
}
