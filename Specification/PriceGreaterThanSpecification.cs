using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public class PriceGreaterThanSpecification : ISpecification<Product>
    {
        private double _price;

        public PriceGreaterThanSpecification(double price)
        {
            _price = price;
        }

        public bool IsSatisfiedBy(Product entity)
        {
            return _price > entity.Price;
        }
    }
}
