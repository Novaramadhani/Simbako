using System;
using System.Collections.Generic;
using System.Text;

namespace SIMBAKO
{
    public class Customer : User
    {
        public override string GetRole()
        {
            return "Customer";
        }
    }
}
