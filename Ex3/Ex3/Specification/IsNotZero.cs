using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Specification
{
    public class IsNotZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value == 0)
            {
                throw new ValidationException(string.Format("Value {0} is null.", value));
            }
        }
    }
}
