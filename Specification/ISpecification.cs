﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public interface ISpecification<T>
    {
        public bool IsSatisfiedBy(T entity);
    }
}
