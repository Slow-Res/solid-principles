using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.OpenClosedPrinciple.Specifications;

namespace SOLID.OpenClosedPrinciple
{
    public class ProductsFilter : IFilter<Product>
    {
        public  IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}