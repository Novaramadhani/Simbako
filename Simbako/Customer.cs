using System;
using System.Collections.Generic;
using System.Text;

namespace Simbako
{
    public class Customer : User
    {
        public override string GetRole()
        {
            return "Customer";
        }
    }
}
