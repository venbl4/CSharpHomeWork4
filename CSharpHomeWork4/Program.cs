using System;

namespace CSharpHomeWork4
{
    class Program
    {


        /*
         * Lebedev Maksim
         * Домашнее задание №4
         * Содержит задания 1 и 2
         */

        static void Main(string[] args)
        {
            //Объявление массива длинной 20 элементов с минимальным и максимальным значениями 
            MyArray myArray = new MyArray(20);
            Console.WriteLine(myArray.ToString());
            myArray.CountPair3();
            myArray.Summa();
            Console.WriteLine("Количество максимальных элементов в массиве: " + myArray.MaxCount);
            MyArray myArray1 = new MyArray(10, -20, 5);
            Console.WriteLine("Созданный массив: " + myArray1);
           // myArray1.Inverse();
            myArray1.Multi(2);
            Console.WriteLine("Умножаем на 2: " + myArray1.ToString());
           // Console.WriteLine("Без инверсии: " + myArray1.ToString());
           // Console.WriteLine("Инверсия: " + myArray1.ToString());
            Console.ReadLine();
        }
    }


    public class MyArray
    {
        //Приватное поле-массив класса Array 
        private int[] numbers;

        
        //Конструктор массива с заполением случаяными числами 
        public MyArray(int n)
        {
            numbers = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                numbers[i] = random.Next(-10000, 10000);
        }

        //Конструктор, создающий массив определенного размера и заполняющий массив
        //числами от начального значения с заданным шагом.
         public MyArray(int n, int min, int step)
         {
             numbers = new int[n];

             for (int i = 0; i  < n; i++)
             {
                 numbers[i] = min + step * i;
             }
         }

        //Метод подсчета пар чисел, которые делятся на 3
        public int CountPair3()
        {
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0 || numbers[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", numbers[i], numbers[i + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            return count;
        }

        //Свойство MaxCount, возвращающее количество максимальных элементов
        public int MaxCount
        {
            get
            {
                int max = numbers[0];
                int count = 1;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        count = 1;
                    }
                    else if (numbers[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        //Метод вывода массива на консоль
        override public string ToString()
        {
            string stringarray = "";
            foreach (int x in numbers)
                stringarray = stringarray + x + " ";
            return stringarray;
        }

        //Метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
        public int[] Inverse(int[] numbers)
        {
            int[] newArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = -numbers[i];
            }
            return newArray;
        }

        //Метод Multi, умножающий каждый элемент массива на определённое число
        public void Multi(int x)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= x;
            }
        }

        //Метод подсчета суммы всех элеиентов массива
        public int Summa()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum +=numbers[i];
            }
            Console.WriteLine("Сумма всех элементов массива = " + sum);
            return sum;

        }
            
            
    }
}
