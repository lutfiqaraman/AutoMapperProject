using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperProject.Input
{
    public class InputCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static InputCustomer BuildInputCustomer()
        {
            return new InputCustomer
            {
                FirstName = "John",
                LastName  = "Doe"
            };
        }
    }
}
