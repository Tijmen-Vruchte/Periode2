using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    public class Person
    {
        private string name;
        private string birthdate;
        private string address;
        private string telephone;
        private string email;

        public Person(string Dename)
        {
            this.name = Dename;
        }
        public string Dename
        {
            get { return Dename; }

        }
        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public override string ToString()
        {
            string tekst = " Name: " + name + "\n Birthdate: " + birthdate + "\n Address: " + address + "\n Telephone: " + telephone + "\n Email: "
                      + email + ".";
            return tekst;
            
        }
    }
}
