using System;
using System.Collections.Generic;
using System.Text;

namespace SIMBAKO
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string NoHp { get; set; }

        // Method abstract - wajib di-override oleh subclass
        public abstract string GetRole();
    }
}