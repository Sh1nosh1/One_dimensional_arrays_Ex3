using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace One_dimensional_arrays_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Задание 1.
                //Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению
                //первого элемента одномерного массива. Если такой элемент имеется, вывести на экран его порядковый номер.
                //Массив состоит из шести элементов.

                /*int[] array = new int[6];
                Random rand = new Random();
                int i;

                for (i=0; i < array.Length; i++)    //В этом блоке заполняем массив случайным образом.
                {
                    array[i] = rand.Next(-25, 25);
                    Console.WriteLine($"Array[{i}] = {array[i]}");
                }
                Console.WriteLine();

                int index = -1;               //Вводим переменную -1, чтобы отследить наличие нужного нам элемента.

                for (i=0; i < array.Length; i++)    //В этом блоке начинаем искать значение. В случае, если оно есть, то переменная index меняет своё значение.
                {
                    if (array[i] == array[0] && i!=0)
                    {
                        index = i;
                        Console.WriteLine($"Индекс = {index}\t\n");
                    }
                }

                if(index==-1)       //Если в прошлом блоке нужного нам значения не нашлось, то index остаётся с введенным нам значением.
                {
                    Console.WriteLine("Значений, равных первому элементу массива, нет");
                }*/

                //Задание 2.
                //Дан одномерный массив. Вывести:
                //а) все неотрицательные элементы;
                //б) все элементы, не превышающие число 100;
                //в) все четные элементы.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-150, 150);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine($"\n\nВсе неотрицательные элементы:\n");
                foreach (int element in array)
                {
                    if (element > 0)
                    {
                        Console.Write($"{element};\t");
                    }
                }
                Console.WriteLine("\n\nВсе элементы, не превышающие число 100:\n");
                foreach(int element in array)
                {
                    if (element < 100)
                    {
                        Console.Write($"{element};\t");
                    }
                }
                Console.WriteLine("\n\nВсе четные элементы:\n");
                foreach (int element in array)
                {
                    if (element % 2 == 0 && element !=0)
                    {
                        Console.Write($"{element};\t");
                    }
                }*/

                //Задание 3.
                //Заполнить одномерный массив без использования клавиатуры следующими значениями: 5, -3, 4,
                //-8, -9, 1, 9, 6, -3, 4, 8, 2.Подсчитать количество отрицательных элементов.

                /*int[] array = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
                int count = 0;
                Console.WriteLine("Отрицательные элементы массива: \n");
                foreach(int element in array)
                {
                    if (element < 0)
                    {
                        Console.Write($"{element};\t");
                        count += 1;
                    }
                }
                Console.WriteLine($"\n\nКоличество отрицательных элементов: {count}");*/

                //Задание 4.
                //Составьте программу вычисления среднего арифметического элементов с нечетными номерами.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                double sum = 0;     //Sum (с англ.) - сумма.
                double mean = 0;    //Mean (с англ.) - среднее значение.
                int count = 0;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-30, 30);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine($"\n\nОтрицательные элементы:\n");
                foreach (int element in array)
                {
                    if(element < 0)
                    {
                        Console.Write($"{element};\t");
                        sum += element;
                        count += 1;  
                    }
                }
                Console.WriteLine($"\n\nСумма отрицательных элементов массива: {sum}\n");
                Console.WriteLine($"Количество отрицательных элементов массива: {count}\n");
                mean = sum / count;
                Console.WriteLine($"Среднее арифметическое отрицательных элементов массива: {mean}");*/

                //Задание 5.
                //Найти количество элементов, лежащих между максимальным
                //и минимальным элементами одномерного массива.

                //НЕ РЕШЕНА

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                int count = 0;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-15, 15);
                    Console.Write($"{array[i]};\t");
                }
                int imax = 0;
                int imin = 0;
                for (i = 0; i <array.Length; i++)
                {
                    if (array[i] > array[imax])
                    {
                        imax = i;
                    }
                    if (array[i] < array[imin])
                    {
                        imin = i;
                    }
                }
                Console.WriteLine($"\nМаксимальное значение: {array[imax]}\nМинимальное значение: {array[imin]}");
                Console.WriteLine("\n\nЭлементы массива между максимальным и минимальным значениями:\n");
                foreach(int element in array)
                {
                    if(element < array[imax] && element > array[imin])
                    {
                        Console.Write($"{element};\t");
                        count += 1;
                    }
                }
                Console.WriteLine($"\n\nКоличество таких элементов: {count}");*/

                //Задание 6.
                //Вычисление в одномерном массиве A(10), заполненного случайным образом
                //целыми числами, количества четных элементов.

                /*int[] array = new int[10];
                Random random = new Random();
                int i;
                int count = 0;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-10, 10);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine("\n\nВсе четные элементы:\n");
                foreach (int element in array)
                {
                    if (element % 2 == 0 && element !=0)
                    {
                        Console.Write($"{element};\t");
                        count += 1;
                    }
                }
                Console.WriteLine($"\n\nКоличество четных элементов: {count}");*/

                //Задание 7.
                //Вычисление в массиве A(N), заполненного случайным образом вещественными числами,
                //суммы всех чисел, кратных 5.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                int sum = 0;
                Console.WriteLine("\nЭлементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-40, 40);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine($"\n\nЧисла, кратные 5:\n");
                foreach (int element in array)
                {
                    if(element % 5 == 0 && element !=0)
                    {
                        Console.Write($"{element};\t");
                        sum += element;
                    }
                }
                Console.WriteLine($"\n\nСумма чисел, кратных 5: {sum}");*/

                //Задание 8.
                //Вычисление среднего арифметического элементов с четными номерами;

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                double sum = 0;     
                double mean = 0;    
                int count = 0;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-50, 50);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine($"\n\nЧетные элементы:\n");
                foreach (int element in array)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write($"{element};\t");
                        sum += element;
                        count += 1;
                    }
                }
                mean = sum / count;
                Console.WriteLine($"\n\nСумма отрицательных элементов массива: {sum}\n");
                Console.WriteLine($"Количество отрицательных элементов массива: {count}\n");
                Console.WriteLine($"Среднее арифметическое отрицательных элементов массива: {mean}");*/

                //Задание 9.
                //Увеличение всех элементов массива в 2 раза;

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                Console.WriteLine("Элементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-15, 15);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine("\n\nЭлементы массива, увеличенные на значение первого элемента:\n");
                foreach(int element in array)
                {
                    Console.Write($"{element + array[0]};\t");
                }*/

                //Задание 10.
                //Формирование из массива A(N) двух массивов, в которых первый массив заполнен положительными,
                //а второй – отрицательными элементами;

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                Console.WriteLine("\nЭлементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-20, 20);
                    Console.Write($"{array[i]};\t");
                }
                Console.WriteLine("\n\nМассив с отрицательными значениями:\n");
                for (i = 0; i < array.Length; i++)
                {
                    if(array[i] < 0)
                    {
                        array[i] = array[i];
                        Console.Write($"{array[i]};\t");
                    }
                }
                Console.WriteLine("\n\nМассив с положительными значениями:\n");
                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = array[i];
                        Console.Write($"{array[i]};\t");
                    }
                }*/

                //Задание 11.
                //Вычисление среднего арифметического индексов максимального и минимального
                //элементов одномерного массива, заполненного с клавиатуры.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                int i;
                double sum = 0;
                double mean = 0;
                Console.WriteLine("\nЭлементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    Console.Write($"Array[{i}] = ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                int imax = 0;
                int imin = 0;
                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] > array[imax])
                    {
                        imax = i;
                    }
                    if (array[i] < array[imin])
                    {
                        imin = i;
                    }
                }
                sum = array[imax] + array[imin];
                mean = sum / 2;
                Console.WriteLine($"\n\nСумма максимального и минимального элементов массива: {sum}\n");
                Console.WriteLine($"Среднее арифметическое максимального и минимального элементов массива: {mean}");*/

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();

        }
    }
}
