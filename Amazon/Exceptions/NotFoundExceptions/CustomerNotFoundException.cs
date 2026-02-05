using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Exceptions.NotFoundExceptions
{
    public class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException() : base("Customer")
        {
        }
    }
}
