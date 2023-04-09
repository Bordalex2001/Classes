using System;

namespace Lab
{
    class Program
    {
        static void Task4() //Задание 4
        {
            Console.WriteLine("Class City");
            City city = new City("Odesa", "Ukraine", 1200000, 048, new string[] { "Kyivskyj", "Prymorskyj", "Malynovskyj", "Suvorovskyj" });
            Console.WriteLine(city);
            Console.WriteLine("\n");
        } 
        static void Task5() //Задание 5
        {
            Console.WriteLine("Class Employee");
            Employee employee = new Employee("Smith", "John", 12, 04, 1954, "johnsmith54@gmail.com", "Software developer", "Creating software programs");
            Console.WriteLine(employee);
            Console.WriteLine("\n");
        }
        static void Task6() //Задание 6
        {
            Console.WriteLine("Class Plane");
            Plane plane = new Plane("Boeing 737", "Boeing Commercial Airplanes", 1967, "Passenger");
            Console.WriteLine(plane);
            Console.WriteLine("\n");
        }
        static void Task7() //Задание 7
        {
            Console.WriteLine("Class Matrix");
            Matrix matrix = new Matrix(new int[,] { { 10, 17, 24 }, { 24, 36, 13 }, { 50, 29, 42 } });
            Console.WriteLine(matrix);
            Console.WriteLine($"Minimum element: {matrix.GetMinimum()}\nMaximum element: {matrix.GetMaximum()}");
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Task4();
            Task5();
            Task6();
            Task7();
        }
    }
}