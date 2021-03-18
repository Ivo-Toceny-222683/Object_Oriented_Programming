using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6_Interfaces.GeoShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            double SumArea = 0;
            double SumSurface = 0;
            double SumVolume = 0;

            GrObject[] objects = new GrObject[8];

            objects[0] = new Ball(3.5);
            objects[1] = new Circle(3.2);
            objects[2] = new Cylinder(2, 5.3);
            objects[3] = new Ellipse(1, 4.7);
            objects[4] = new Pyramid(2, 3, 6.4);
            objects[5] = new Rectangle(4, 6.2);
            objects[6] = new Squares(4.2, 2, 3);
            objects[7] = new Triangle(5.2, 3.4, 5);

            foreach(GrObject shape in objects)
            {
                shape.Draw();

                if (shape is Object2D)
                {
                    Console.WriteLine("Area: {0}\n", ((Object2D)shape).GetArea());
                    SumArea += ((Object2D)shape).GetArea();
                }
                else
                {
                    Console.WriteLine("Surface: {0}", ((Object3D)shape).GetSurface());
                    Console.WriteLine("Volume: {0}\n", ((Object3D)shape).GetVolume());
                    SumSurface += ((Object3D)shape).GetSurface();
                    SumVolume += ((Object3D)shape).GetVolume();
                }
            }
            Console.WriteLine("SumArea: {0}\nSumSurface: {1}\nSumVolume: {2}", SumArea, SumSurface, SumVolume);
        }
    }
}
