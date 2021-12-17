using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Specification
{
    class IsMoreThenZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value <= 0)
            {
                throw new ValidationException(string.Format("Value {0} must be more than zero.", value));
            }
        }
    }
}
