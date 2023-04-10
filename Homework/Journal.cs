using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Journal
    {
        private string name; //название журнала
        private int year; //год основания
        private string description; //описание
        private string telephone; //телефон
        private string email; //эл. адрес
        public Journal()
        {
            name = null;
            year = 0;
            description = null;
            telephone = null;
            email = null;
        }
        public Journal(string name, int year, string description, string telephone, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.telephone = telephone;
            this.email = email;
        }
        public string Name 
        { 
            get { return name; } set { name = value; }
        }
        public int Year
        { 
            get { return year; } set { year = value; } 
        }
        public string Description
        {
            get { return description; } set { description = value; }
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
            return $"Name: {name}\nYear: {year}\nDescription: {description}\nTelephone: {telephone}\nEmail: {email}";
        }
    }
}
