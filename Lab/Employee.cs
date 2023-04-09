using System;

namespace Lab
{
    internal class Employee
    {
        private string surname; //фамилия
        private string name; //имя
        private int birthday; //день рождения
        private int birthmonth; //месяц рождения
        private int birthyear; //год рождения
        private string email; //рабочий эл. адрес
        private string position; //должность
        private string duties; //обязанности сотрудника
        public Employee()
        {
            surname = null;
            name = null;
            birthday = 0;
            birthmonth = 0;
            birthyear = 0;
            email = null;
            position = null;
            duties = null;
        }
        public Employee(string surname, string name, int birthday, int birthmonth, int birthyear, string email, string position, string duties)
        {
            this.surname = surname;
            this.name = name;
            this.birthday = birthday;
            this.birthmonth = birthmonth;
            this.birthyear = birthyear;
            this.email = email;
            this.position = position;
            this.duties = duties;
        }
        public string Surname
        {
            get { return surname; } set {  surname = value; }
        }
        public string Name
        { 
            get { return name; } set {  name = value; } 
        }
        public int Birthdate
        {
            get { return birthday; } set { birthday = value; }
        }
        public int Birthmonth
        {
            get { return birthmonth; } set { birthmonth = value; }
        }
        public int Birthyear
        {
            get { return birthyear; } set { birthyear = value; }
        }
        public string Email
        {
            get { return email; } set { email = value; }
        }
        public string Position
        {
            get { return position; } set { position = value; }
        }
        public string Duties 
        {
            get { return duties; } set { duties = value; }
        }
        public override string ToString()
        {
            return $"Surname: {surname}\nName: {name}\nDate of birth: {birthday}.{birthmonth}.{birthyear}\nEmail: {email}\nPosition: {position}\nOfficial duties: {duties}";
        }
    }
}
