using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_1
{
    public class Square : Shape
    {


        public double Width { get; set; }
        public Square(string name, int id, Opacity opacity, Color color, double width) : base(name, id, opacity, color)
        {
            Width = width;
        }
        public override double CalculateArea()
        {
            return Math.Pow(Width, 2);
        }
    }
}
