using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_1
{
    public class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }


        public Rectangle(string name, int id, Opacity opacity, Color color, double lenght, double width) : base(name, id, opacity, color)
        {
            Length = lenght;
            Width = width;


        }


        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
