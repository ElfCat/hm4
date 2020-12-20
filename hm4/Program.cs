using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hm4
{

    class MyArray
    {
        int[] a;
        public MyArray(int n)
        {
            a = new int[n];
        }
        public int Get(int i)
        {
            return a[i];
        }

        public void Set(int i, int value)
        {
            a[i] = value;
            Console.Write(a[i] + " ");
        }

        public void Sum(int n)
        {
            int sumAr = 0;
            for (int i = 0; i < n; i++)
            {
                sumAr = sumAr + a[i];
            }
            Console.Write("\nСумма элементов массива: " + sumAr);
        }

        public void Inverse(int n)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] * -1;
            }
        }

        public void Multi(int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = a[i] * k;
            }
        }

        public void MaxCount(int n)
        {
            int count = 0;
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (max == a[i])
                {
                    count++;
                }
            }
            Console.Write($"\nКоличество элементов с максимальным значением (max = {max}): {count}");
        }

        public void Print(int n) //создаем метод для вывода массива на экран
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " "); //выводим массив

            }
        }

    }

    struct Account
    {
        public string usLog;
        public string usPass;

        public static bool Check(string[,] arr, Account userData)   // проверка введного пользователем логина/пароля
        {

            for (int i = 0; i < (arr.GetUpperBound(0) + 1); i++)
            {
                if (userData.usLog == arr[i, 0] && userData.usPass == arr[i, 1])
                {
                    return true;
                }
            }
            return false;
        }
    }

    class MyArray2d
    {

        int[,] a;

        public MyArray2d(int n, int el)
        {
            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = el;
        }
        public MyArray2d(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }

        public void Print(int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        Console.Write(a[i, j] + "\n");
                    }
                    else
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
        }

        public void Sum()//Сумма элементов двумерного массива
        {
            int sumAr2 = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sumAr2 = sumAr2 + a[i, j];
                }
            }
            Console.Write("\nСумма элементов массива: " + sumAr2);
        }
        public void SumG(int g)//Сумма элементов двумерного массива больше заданного
        {
            int sumAr2 = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > g)
                        sumAr2 = sumAr2 + a[i, j];
                }
            }
            Console.Write("Сумма элементов массива: " + sumAr2);
        }
        public int Min  //возвращение мин элемента
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {


                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max  //возвращение мин элемента
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public void MaxEl(out string h)
        {
            h = "";
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        h = h + $"[{i}, {j}] ";
                    }
                }
            }
        }

    }


    class Program
    {


        public static string[,] ExtractFromFile(string f)
        {

            if (File.Exists(f))
            {
                StreamReader reader = new StreamReader(f);

                string[] arr = File.ReadAllLines(f, System.Text.Encoding.Default);
                string[,] arr2 = new string[arr.Length, 2];

                for (int i = 0; i < arr.Length; i++)
                {
                    string[] vs = arr[i].Split(' ');

                    for (int j = 0; j < 2; j++)
                    {
                        arr2[i, j] = vs[j];
                    }
                }

                return arr2;
            }
            else
            {
                throw new Exception("File not found");
            }
        }
        static void Main(string[] args)
        {
            #region Зад.1

            Console.WriteLine("Задание 1");


            int[] a;
            a = new int[20];
            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    a[i] = rand.Next(-10000, 10000);
                    Console.Write(a[i] + "\n");
                }
                else
                {
                    a[i] = rand.Next(-10000, 10000);
                    Console.Write(a[i] + "; ");

                }
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                {
                    count++;
                }

            }

            Console.Write("Количество пар элементов массива, в которых хотя бы одно число делится на 3: " + count);


            #endregion

            #region Зад.2

            Console.WriteLine("\n\nЗадание 2");

            Console.Write("Введите размерность массива: ");
            int userAL = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 1 элемент массива: ");
            int firstN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг изменения элементов массива: ");
            int step = Convert.ToInt32(Console.ReadLine());

            MyArray myArray = new MyArray(userAL);

            for (int i = 0; i < userAL; i++)
            {
                myArray.Set(i, firstN + step * i);
            }

            myArray.Sum(userAL);

            myArray.Inverse(userAL);
            Console.Write("\nЭлементы массива с противоположными знаками: ");
            myArray.Print(userAL);


            Console.Write("\nВведите число, на которое будут умножены элеменнты массива: ");
            int userMulti = Convert.ToInt32(Console.ReadLine());
            myArray.Multi(userAL, userMulti);
            myArray.Print(userAL);


            myArray.MaxCount(userAL);

            #endregion

            #region Зад.3

            Console.WriteLine("\n\nЗадание 3");

            var file = AppDomain.CurrentDomain.BaseDirectory + "Login_Password.txt";

            var arr = ExtractFromFile(file);


            Account userData = new Account();

            Console.Write("Login/Password for authorization:\n");
            for (int i = 0; i < (arr.GetUpperBound(0) + 1); i++)
            {
                Console.WriteLine((i + 1) + ". " + arr[i, 0] + "/" + arr[i, 1]);

            }

            do
            {
                Console.Write("Введите логин: ");
                userData.usLog = Console.ReadLine();
                Console.Write("Введите пароль: ");
                userData.usPass = Console.ReadLine();
                if (Account.Check(arr, userData))
                {
                    Console.Write("Welcome! Authorization successfully completed");
                    break;
                }
                else
                {
                    Console.Write("Your password/login invalid\n");
                }
            } while (!Account.Check(arr, userData));

            #endregion

            #region Зад.4

            Console.WriteLine("\n\nЗадание 4");

            int k = 5;

            Console.Write("Двумерный массив: \n");

            MyArray2d b = new MyArray2d(k, 1, 10);
            b.Print(k);
            b.Sum();

            Console.Write("\n\nВведите число для подсчета суммы элементов массива больше него: ");
            int g = Convert.ToInt32(Console.ReadLine());
            b.SumG(g);


            Console.WriteLine("\n\nМаксимальный элемент: " + b.Max);
            Console.WriteLine("Минимальный элемент: " + b.Min);

            Console.Write("\nНомер первого максимального элемента массива: ");
            b.MaxEl(out string ijMax);
            Console.Write(ijMax);

            #endregion

            Console.ReadLine();
        }
    }
}
