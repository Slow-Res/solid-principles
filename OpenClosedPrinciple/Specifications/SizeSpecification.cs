using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.OpenClosedPrinciple.Enums;

namespace SOLID.OpenClosedPrinciple.Specifications
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }
}