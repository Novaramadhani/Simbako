using System;
using System.Collections.Generic;
using System.Text;

// File: User.cs
namespace Simbako
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Nama { get; set; } = string.Empty;
        public string NoHp { get; set; } = string.Empty;

        public abstract string GetRole();
    }
}