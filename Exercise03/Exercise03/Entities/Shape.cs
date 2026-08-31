using Exercise03.Entities.Enums;

namespace Exercise03.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}