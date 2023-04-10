using System;

namespace Homework
{
    internal class Website
    {
        private string name; //название сайта
        private string url; //путь к сайту
        private string description; //описание
        private string ip; //ip адрес
        public Website()
        {
            name = null; 
            url = null; 
            description = null; 
            ip = null; 
        }
        public Website(string name, string url, string description, string ip)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }
        public string Name
        {
            get { return name; }  set { name = value; }
        }
        public string URL
        { 
            get { return url; } set { url = value; } 
        }
        public string Description
        {
            get { return description; } set { description = value; }
        }
        public string IP
        { 
            get { return ip; } set { ip = value; } 
        }
        public override string ToString()
        {
            return $"Name: {name}\nURL: {url}\nDescription: {description}\nIP address: {ip}";
        }
    }
}
