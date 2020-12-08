using Abstract_methods.Entities;
using Abstract_methods.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read the data of N shapes (N provided by the user), and then show the areas of these shapes in the same order they were typed.*/

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Cicle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) : ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));

                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
