using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Store
    {
        private string name; //название магазина
        private string address; //адрес
        private string profile; //профиль
        private string telephone; //телефон
        private string email; //эл. адрес
        public Store()
        {
            name = null;
            address = null;
            profile = null;
            telephone = null;
            email = null;
        }
        public Store(string name, string address, string profile, string telephone, string email)
        {
            this.name = name;
            this.address = address;
            this.profile = profile;
            this.telephone = telephone;
            this.email = email;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public string Address
        {
            get { return address; } set { address = value; }
        }
        public string Profile
        {
            get { return profile; } set { profile = value; }
        }
        public string Telephone
        {
            get { return telephone; } set { telephone = value; }
        }
        public string Email
        {
            get { return email; } set { email = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}\nAddress: {address}\nProfile: {profile}\nTelephone: {telephone}\nEmail: {email}";
        }
    }
}
