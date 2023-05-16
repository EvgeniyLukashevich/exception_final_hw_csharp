using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using personDataInput.OwnExceptions;

namespace personDataInput.OwnExceptions
{
    public class DateFormatException : Exception
    {
        /*
        static void NewMethod()
        {
            DateFormatException fm = new DateFormatException("ERROR: ", "fsdf");
            string userDate = fm.UserDate;
            string errorMessage = fm.Message;
            Console.WriteLine(errorMessage + userDate);

        }
        */

        private readonly string userDate;

        public string UserDate
        {
            get { return userDate; }
        }

        public DateFormatException(string message, string userDate) : base(message)
        {
            this.userDate = userDate;
        }
    }
}

