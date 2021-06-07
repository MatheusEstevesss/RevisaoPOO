using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();// o método não recebe implementação pois é abstrato de mais.
    }
}
