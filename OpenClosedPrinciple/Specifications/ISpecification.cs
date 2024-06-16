using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}