using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class PhoneFormatException : Exception
    {
        private readonly string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }

        public PhoneFormatException(string message, string phoneNumber) : base(message)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}