using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _4_8
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
            set
            {
                if (value.Length == 11)
                {
                    telephone = value;
                }
                else
                {
                    Console.WriteLine("!!!TELEPHONE EROOR!!!");

                }
            }
                
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
