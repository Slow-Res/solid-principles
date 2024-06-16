using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.OpenClosedPrinciple.Specifications
{
    public class PriceSpecification : ISpecification<Product>
    {
        decimal? _minPrice;
        decimal? _maxPrice;

        public PriceSpecification(decimal? minPrice = null, decimal? maxPrice = null)
        {
            _minPrice = minPrice;
            _maxPrice = maxPrice;
        }

        public bool IsSatisfied(Product t)
        {
            if (_minPrice.HasValue && _maxPrice.HasValue)
                return t.Price >= _minPrice && t.Price <= _maxPrice;
            else if (_minPrice.HasValue)
                return t.Price >= _minPrice;

            else if (_maxPrice.HasValue)
                return t.Price <= _maxPrice;
            else
                throw new ArgumentException("Both minPrice and maxPrice cannot be null");
        }
    }
}