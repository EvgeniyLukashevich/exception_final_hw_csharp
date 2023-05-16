using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personDataInput.Models
{
    public class Person 
    { 
        private string lastName; 
        private string firstName; 
        private string middleName; 
        private string dateOfBirth; 
        private long phoneNumber; 
        private char gender;

        private Person() {}

        public string LastName 
        {
            get { return this.lastName; }
        }

        public string FirstName 
        {
            get { return this.firstName; }
        }

        public string MiddleName 
        {
            get { return this.middleName; }
        }

        public string DateOfBirth 
        {
            get { return this.dateOfBirth; }
        }

        public long PhoneNumber 
        {
            get { return this.phoneNumber; }
        }

        public char Gender 
        {
            get { return this.gender; }
        }

        public class Builder 
        {
            private string lastName = "Неизвестно";
            private string firstName = "Неизвестно";
            private string middleName = "Неизвестно";
            private string dateOfBirth = "-1.-1.-1";
            private long phoneNumber = (long) -1;
            private char gender = '-';

            public Person Build() 
            {
                Person person = new Person();
                person.lastName = this.lastName;
                person.firstName = this.firstName;
                person.middleName = this.middleName;
                person.dateOfBirth = this.dateOfBirth;
                person.phoneNumber = this.phoneNumber;
                person.gender = this.gender;
                return person;
            }

            public Builder SetLastName(string lastName) 
            {
                this.lastName = lastName;
                return this;
            }

            public Builder SetFirstName(string firstName) 
            {
                this.firstName = firstName;
                return this;
            }

            public Builder SetMiddleName(string middleName) 
            {
                this.middleName = middleName;
                return this;
            }

            public Builder SetDateOfBirth(string dateOfBirth) 
            {
                this.dateOfBirth = dateOfBirth;
                return this;
            }

            public Builder SetPhoneNumber(long phoneNumber) 
            {
                this.phoneNumber = phoneNumber;
                return this;
            }

            public Builder SetGender(char gender) 
            {
                this.gender = gender;
                return this;
            }
        }
    }
}