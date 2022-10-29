using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Contacts
    {
        //Properties
        private string name;
        private string lastname;
        private string phone;
        private string email;

        //Constructors
        public Contacts(string name, string lastname, string phone, string email)
        {
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.email = email;
        }


        //Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLastName(string lastname)
        {
            this.lastname = lastname;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        //Getters
        public string GetName()
        {
            return name;
        }

        public string GetLastName()
        {
            return lastname;
        }

        public string GetPhone()
        {
            return phone;
        }

        public string GetEmail()
        {
            return email;
        }

        //Behaviours
        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(obj == this)
            {
                return true;
            }

            if(this.GetType() != obj.GetType())
            {
                return false;
            }

            Contacts other = (Contacts)obj;

            return (this.name.Equals(other.name) && this.lastname.Equals(other.lastname)) && this.phone.Equals(other.phone) && this.email.Equals(other.email);
        }

        public override string ToString()
        {
            return ($"{this.name}      {this.lastname}      {this.phone}            {this.email}\n");
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
