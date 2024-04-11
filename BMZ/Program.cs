using BMZ.Classes;
using BMZ.Interface;

namespace BMZ
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape[] shapes = new IShape[]
            {
                new Square(5),
                new Triangle(5),
                new Circle(5)
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

        }

        
    }
}
