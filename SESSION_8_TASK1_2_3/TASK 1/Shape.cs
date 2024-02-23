using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESSION_8_TASK1_2_3.TASK_1
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Opacity Opacity { get; set; }
        public Color Color { get; set; }

        public Shape(string name, int id, Opacity opacity, Color color)
        {
            Name = name;
            Id = id;
            Opacity = opacity;
            Color = color;
        }
        public abstract double CalculateArea();
        public virtual void ShowShapeData()
        {
            Console.WriteLine($"Name={Name} , ID={Id} , Opacity={Opacity} , Color={Color}");
        }
    }
}
