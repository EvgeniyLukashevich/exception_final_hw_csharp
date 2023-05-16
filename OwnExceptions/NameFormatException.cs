using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class NameFormatException : Exception
    {
        private readonly string anyName;
        public string AnyName
        {
            get { return anyName; }
        }
        public NameFormatException(string message, string anyName) : base(message)
        {
            this.anyName = anyName;
        }
    }
}