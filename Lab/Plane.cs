using System;

namespace Lab
{
    internal class Plane
    {
        private string name; //название самолёта
        private string producer; //завод-производитель
        private int year; //год выпуска
        private string type; //тип самолёта
        public Plane()
        {
            name = null;
            producer = null;
            year = 0;
            type = null;
        }
        public Plane(string name, string producer, int year, string type)
        {
            this.name = name;
            this.producer = producer;
            this.year = year;
            this.type = type;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public string Producer
        {
            get { return producer; } set { producer = value; }
        }
        public int Year
        { 
            get { return year; } set {  year = value; } 
        }
        public string Type
        { 
            get { return type; } set {  type = value; } 
        }
        public override string ToString()
        {
            return $"Name: {name}\nProducer: {producer}\nYear: {year}\nType: {type}";
        }
    }
}
