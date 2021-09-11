using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Home_work_2
{
    class Program
    {
        //Шаповаленко Ксения
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("МЕНЮ");
                Console.WriteLine("Нажмите 0, чтобы выйти");
                Console.WriteLine("Нажмите 1, чтобы просмотреть первую задачу");
                Console.WriteLine("Нажмите 2, чтобы просмотреть вторую задачу");
                Console.WriteLine("Нажмите 3, чтобы просмотреть третью задачу");
                Console.WriteLine("Нажмите 4, чтобы просмотреть четвертую задачу");
                Console.WriteLine("Нажмите 5, чтобы просмотреть пятую задачу");
                Console.WriteLine("Нажмите 6, чтобы просмотреть шестую задачу");
                Console.WriteLine("Нажмите 7, чтобы просмотреть седьмую задачу");
                Console.WriteLine("================================================");
                Console.WriteLine("");
                Console.Write("Введите номер: ");
                int taskNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("================================================");
                Console.WriteLine("");
                switch (taskNumber)
                {
                    case 0:
                        Console.WriteLine("Завершение работы программы");
                        Console.ReadLine();
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        break;
                }
            }
        }
        #region Task_1
        static void Task1() 
        {
            //Написать метод, возвращающий минимальное из трёх чисел.
            

            Console.WriteLine("Введите 3 числа");
            Console.Write("Первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Третье число: ");
            double c = double.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine($"{a} - минимальное число");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"{b} - минимальное число");
            }
            else if (c < a && c < b)
            {
                Console.WriteLine($"{c} - минимальное число");
            }
            else if (a == b && a < c)
            {
                Console.WriteLine($"{a} и {b} - минимальные числа");
            }
            else if (a == c && a < b)
            {
                Console.WriteLine($"{a} и {c} - минимальные числа");
            }
            else if (b == c && b < a)
            {
                Console.WriteLine($"{b} и {c} - минимальные числа");
            }
            else { Console.WriteLine($"{a},{b} и {c} - равные числа, поэтому минимального числа нет"); }
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region Task_2
        static void Task2()
        {
            //Написать метод подсчета количества цифр числа.
            int count = 0;
            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());
            int a1 = a;
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            Console.WriteLine($"Количество цифр в числе {a1} равно {count}");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region Task_3
        static void Task3()
        {
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            int a;
            int sum = 0;
            Console.WriteLine("В задаче ведётся подсчет суммы всех нечетных положительных чисел (чтобы закончить ввод нажмите 0).");
            do
            {
                Console.WriteLine("Введите число");
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0 && a > 0)
                {
                    sum = sum + a;
                }
            }
            while (a != 0);
            Console.WriteLine(sum != 0 ? ("Сумма нечетных положительных чисел равна " + sum) : ("Вы не ввели нечетные положительные числа"));
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region Task_4
        static void Task4()
        {
            /*
              Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
              На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
              Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
              программа пропускает его дальше или не пропускает. 
              С помощью цикла do while ограничить ввод пароля тремя попытками.
             */
            bool test;
            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string passW = Console.ReadLine();
                count++;
                test = (login == "root" && passW == "GeekBrains") ? true : false;
                if (test == false)
                {
                    Console.WriteLine($"Вы не прошли авторизацию! Количество оствашихся попыток: {3 - count}");
                }
                Console.WriteLine("");
            }
            while (test == false && count != 3);
            Console.WriteLine(test == true ? "Вы прошли авторизацию!" : "Иссякло количество попыток!");
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Task_5
        static void Task5()
        {
            /*
             а) Написать программу, которая запрашивает массу и рост человека, 
             вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
             б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            */
            Console.Write("Введите ваш рост в метрах: ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите вашу массу в килограммах: ");
            double m = double.Parse(Console.ReadLine());

            double I = Math.Round(m / (h * h), 2);

            if (I < 18.5)
            {
                Console.WriteLine($"Ваш индекс массы тела равен {I}. Наблюдается недостаток массы тела.");
                Console.WriteLine("Вам необходимо набрать как минимум {0}кг", GetNewWeight(18.5, h, m));

            }
            else if (I <= 24.9)
            {
                Console.WriteLine($"Ваш индекс массы тела равен {I}. Это нормальный вес.");
            }
            else if (I <= 29.9)
            {
                Console.WriteLine($"Ваш индекс массы тела равен {I}. Наблюдается избытчный вес.");
                Console.WriteLine("Вам необходимо скинуть как минимум {0}кг", GetNewWeight(24.9, h, m));
            }
            else
            {
                Console.WriteLine($"Ваш индекс массы тела равен {I}. Вы страдайте ожирением.");
                Console.WriteLine("Вам необходимо скинуть как минимум {0}кг", GetNewWeight(24.9, h, m));
            }
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Task_6
        static void Task6()
        {
            /*
             Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
             «Хорошим» называется число, которое делится на сумму своих цифр. 
             Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
             */
            DateTime Stime = DateTime.Now;
            int count = 0;
            for (int i=1; i<=1000000000; i++) 
            {
                if (i % SumNumbers(i) == 0) 
                {
                    count++;
                }
            }
            DateTime Ftime = DateTime.Now;
            Console.WriteLine($"Количество «хороших» чисел в диапазоне от 1 до 1 000 000 000 равно {count}");
            Console.WriteLine($"Время выполнения программы равно {Ftime-Stime}");
            Console.ReadLine();
            Console.Clear();

        }
        #endregion

        #region Task_7
        static void Task7()
        {
            /*
             a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
             б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
             */
            Console.WriteLine("Введите начальное число интервала");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите конечное число интервала");
                int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Начальное число должно быть больше конечного!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Write("Ряд: ");
                Count(a, b);
                Console.WriteLine("");
                Console.WriteLine($"Сумма чисел ряда равна {Sum(a, b)}");
                Console.ReadLine();
                Console.Clear();
            }

        }
        #endregion

        #region Other
        static double GetNewWeight(double I0, double h, double m1) 
        {
            double m0 = I0 * h * h;
            return Math.Round(Math.Abs(m0-m1), 2);
        }
        static int SumNumbers(int a)
        {
            if (a == 0)                                  
                return 0;                             
            else return SumNumbers(a / 10) + a % 10;
        }
        static void Count(int a, int b) 
        {

            if (a<=b)
            {
                Console.Write($"{a} ");
                Count(a + 1, b);
            }
        }
        static int Sum(int a, int b)
        {
            if (a > b) return 0;
            else return Sum(a + 1, b)+a;
        }
        #endregion
         
    }
}
