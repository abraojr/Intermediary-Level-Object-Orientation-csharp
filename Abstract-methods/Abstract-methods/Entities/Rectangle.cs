using Abstract_methods.Entities.Enums;

namespace Abstract_methods.Entities
{
    class Rectangle : Shape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height, Color color) : base(color)
        {
            Widht = widht;
            Height = height;
        }
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
