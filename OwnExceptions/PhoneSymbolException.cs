using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class PhoneSymbolException : PhoneFormatException
    {
        public PhoneSymbolException(string message, string phoneNumber) 
        : base(message, phoneNumber) { }
    }
}