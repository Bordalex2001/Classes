using System;

namespace Lab
{
    internal class Matrix
    {
        private int[,] array; //массив матрицы
        public Matrix() 
        {
            array = null;
        }
        public Matrix(int[,] array) 
        {  
            this.array = array; 
        }
        public int[,] Array
        { 
            get { return array; } set { array = value; }
        }
        public int GetMinimum() //поиск минимума
        {
            int min = array[0, 0];
            foreach (int i in array)
            {
                min = Math.Min(min, i);
            }
            return min;
        }
        public int GetMaximum() //поиск максимума
        {
            int max = array[0, 0];
            foreach(int i in array)
            {
                max = Math.Max(max, i);
            }
            return max;
        }
        public override string ToString() //вывод массива
        {
            string num = string.Empty;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    num += array[i, j].ToString() + "  ";
                }
                num += "\n";
            }
            return num;
        }
    }
}
