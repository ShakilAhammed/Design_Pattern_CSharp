using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> sp1;
        private ISpecification<T> sp2;

        public AndSpecification(ISpecification<T> sp1, ISpecification<T> sp2)
        {
            this.sp1 = sp1;
            this.sp2 = sp2;
        }
    
        public bool IsSatisfiedBy(T entity)
        {
            return sp1.IsSatisfiedBy(entity) && sp2.IsSatisfiedBy(entity);
        }
    }
}
