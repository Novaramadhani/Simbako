using System;
using System.Collections.Generic;
using System.Text;

namespace Simbako.Model
{
    public class Petani : User
    {
        public override string GetRole()
        {
            return "Petani";
        }
    }
}