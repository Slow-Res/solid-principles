using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SOLID.OpenClosedPrinciple.Specifications;

namespace SOLID.OpenClosedPrinciple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);   
    }
}