using Abstract_Methods.Entities.Enums;

namespace Abstract_Methods.Entities
{
    abstract class Shape // classe abstrata
    {
        public Color Color { get; set; }

        public Shape (Color color)
        {
            Color = color;
        }

        public abstract double Area();
        // para implementar metodos abstratos, a classe deve ser abstrata.
    }
}
