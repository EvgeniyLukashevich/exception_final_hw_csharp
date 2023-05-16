using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.OwnExceptions
{
    public class LineSizeException : Exception
    {
        private readonly string userLine;

        public string UserLine
        {
            get { return userLine; }
        }

        public LineSizeException(string message, string userLine) : base(message)
        {
            this.userLine = userLine;
        }
    }
}