using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneableWork
{
    //Глубокое клонирование (Deep copy)
    public class Point: ICloneable
    {
        public int x, y;
        public Point()
        {
            
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //Реализация ICloneable
        public object Clone()
        {
            return new Point(this.x, this.y) as object;
        }
        public override string ToString()
        {
            return $"X: {this.x} Y: {this.y}";
        }
    }
}
