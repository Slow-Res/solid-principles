using System;
using System.Collections.Generic;
using SOLID.OpenClosedPrinciple.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.Specifications
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color  color;

        public ColorSpecification(Color color) 
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }
}