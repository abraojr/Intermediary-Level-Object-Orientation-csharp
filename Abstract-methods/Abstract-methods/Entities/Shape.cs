using Abstract_methods.Entities.Enums;

namespace Abstract_methods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }
        //If a class has at least one abstract method, then this class is also abstract.
        public abstract double Area();
    }
}
