using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class GenderFormatException : Exception
    {
        private readonly string userGender;

        public string UserGender
        {
            get { return userGender; }
        }

        public GenderFormatException(string message, string userGender) : base(message)
        {
            this.userGender = userGender;
        }
    }
}