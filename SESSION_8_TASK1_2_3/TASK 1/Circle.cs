using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_1
{
    public class Circle : Shape
    {
        public double PI = 22 / 7;


        public double Diameter { get; set; }
        public Circle(string name, int id, Opacity opacity, Color color, double diameter) : base(name, id, opacity, color)
        {
            Diameter = diameter;
        }

        public override double CalculateArea()
        {
            return PI * Math.Pow(Diameter, 2);
        }
    }
}
