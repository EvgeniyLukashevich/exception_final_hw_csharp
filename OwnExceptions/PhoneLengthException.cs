using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class PhoneLengthException : PhoneFormatException
    {
        public PhoneLengthException(string message, string phoneNumber) 
        : base(message, phoneNumber) { }
    }
}