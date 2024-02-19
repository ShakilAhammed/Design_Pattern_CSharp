using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfiedBy(Product product)
        {
            return _color == product.Color;
        }
    }
}
