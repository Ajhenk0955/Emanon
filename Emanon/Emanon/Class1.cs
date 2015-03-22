using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanon
{
    class Class1
    {
    }
    public class Patient
    {
        private string firstName;
        private string lastName;
        private string middleInitial;
        private string city;
        private string state;
        private int zipCode;
        private string address;
        private int ssn; //may need more protection
        private int phoneNumber;

        public Patient(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleInitial
        {
            get { return middleInitial; }
            set { middleInitial = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
