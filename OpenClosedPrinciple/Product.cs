using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.OpenClosedPrinciple.Enums;

namespace SOLID.OpenClosedPrinciple
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public decimal Price;

        public Product(string name, Color color, Size size, int price)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
            Price = price;
        }
    }
}