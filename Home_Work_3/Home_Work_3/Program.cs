using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("МЕНЮ");
                Console.WriteLine("Нажмите 0, чтобы выйти");
                Console.WriteLine("Нажмите 1, чтобы просмотреть первую задачу");
                Console.WriteLine("Нажмите 2, чтобы просмотреть вторую задачу");
                Console.WriteLine("Нажмите 3, чтобы просмотреть третью задачу");
                Console.WriteLine("================================================");
                Console.WriteLine();
                int taskNumber;
                string a;
                do
                {
                    Console.Write("Введите номер: ");
                    a = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("================================================");
                    Console.WriteLine();
                }
                while (int.TryParse(a, out taskNumber) == false);
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
                    
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                        Console.WriteLine();
                        break;
                }
            }
        }
        

        #region Task1
        static void Task1()
        { /*
            а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            в) Добавить диалог с использованием switch демонстрирующий работу класса.
             */
            Console.Clear();
            Console.WriteLine("Для того, чтобы продемонстрировать работу структуры нажмите 1");
            Console.WriteLine("Для того, чтобы продемонстрировать работу класса нажмите 2");
            Console.Write("Введите номер: ");
            string s = Console.ReadLine();
            int taskNumber;
            if (int.TryParse(s, out taskNumber))
            {
                switch (taskNumber)
                {
                    case 1:

                        Console.Clear();
                        Complex complex1;
                        complex1.re = 2;
                        complex1.im = -3;

                        Complex complex2;
                        complex2.re = 5;
                        complex2.im = 8;

                        Complex sum = complex1.Sum(complex2);
                        Complex proiz = complex1.Proizv(complex2);
                        Complex minus = complex1.Minus(complex2);

                        Console.WriteLine($"Сумма комплексных чисел {complex1.ToString()} и {complex2.ToString()} равна {sum.ToString()}");
                        Console.WriteLine($"Разность комплексных чисел {complex1.ToString()} и {complex2.ToString()} равна {minus.ToString()}");
                        Console.WriteLine($"Произведение комплексных чисел {complex1.ToString()} и {complex2.ToString()} равно {proiz.ToString()}");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 2:
                        Console.Clear();
                        while (true)
                        {

                            Console.WriteLine("Для того, чтобы выйти нажмите 0");
                            Console.WriteLine("Для того, чтобы сложить комплексные числа нажмите 1");
                            Console.WriteLine("Для того, чтобы вычесть комплексные числа нажмите 2");
                            Console.WriteLine("Для того, чтобы перемножить комплексные числа нажмите 3");
                            string s1;
                            int taskNumberB;
                            bool flag;
                            do
                            {
                                Console.Write("Введите номер: ");
                                s1 = Console.ReadLine();
                                flag = int.TryParse(s1, out taskNumberB);
                            }
                            while (!flag);

                            Complex1 complex11 = new Complex1();
                            complex11.re = 2;
                            complex11.im = -3;

                            Complex1 complex22 = new Complex1();
                            complex22.re = 5;
                            complex22.im = 8;


                            switch (taskNumberB)
                            {
                                case 0:
                                    Console.WriteLine("Завершение работы программы");
                                    Console.ReadLine();
                                    Console.Clear();
                                    return;

                                case 1:
                                    Complex1 sum1 = complex11.Sum(complex22);
                                    Console.WriteLine($"Сумма комплексных чисел {complex11.ToString()} и {complex22.ToString()} равна {sum1.ToString()}");
                                    Console.ReadLine();
                                    break;

                                case 2:
                                    Complex1 minus1 = complex11.Minus(complex22);
                                    Console.WriteLine($"Разность комплексных чисел {complex11.ToString()} и {complex22.ToString()} равна {minus1.ToString()}");
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    Complex1 proiz1 = complex11.Proizv(complex22);
                                    Console.WriteLine($"Произведение комплексных чисел {complex11.ToString()} и {complex22.ToString()} равно {proiz1.ToString()}");

                                    Console.ReadLine();
                                    break;

                                default:
                                    Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                                    break;
                            }
                        }
                        

                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод.");
                            break;
                        
                }

            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
            Console.Clear();
        }
        #endregion

        #region Task2
        static void Task2()
        {
            /*
             С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
             Требуется подсчитать сумму всех нечётных положительных чисел. 
             Сами числа и сумму вывести на экран, используя tryParse.
             */
            double sum = 0;
            double a;
            string str;
            bool flag;
            do
            {
                Console.WriteLine("Введите число");
                str = Console.ReadLine();
                flag=double.TryParse(str,out a);
                if (flag)
                {
                    if (a % 2 != 0 && a > 0)
                    {
                        sum = sum + a;
                    }
                }
                else 
                {
                    Console.WriteLine("Это не число!");
                    Console.WriteLine();
                }
            }
            while (str != "0");
            Console.WriteLine($"Cумма всех введенных нечётных положительных чисел равна {sum}");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion

        #region Task3
        static void Task3()
        {
            /*
             *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
             Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
             Написать программу, демонстрирующую все разработанные элементы класса.
             */

        }
        #endregion

        #region Complex(Struct)

        struct Complex
        {
            public double im;
            public double re;

            public Complex Sum(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public Complex Proizv(Complex x)
            {
                Complex y;
                y.re=re*x.re-im*x.im;
                y.im = re * x.im + im * x.re;
                return y;

            }

            public string ToString() 
            {
                return $"{re}+{im}i";
            }
        }



        #endregion

        #region Complex(Class)
        class Complex1 
        {
            public double im;
            public double re;


            public Complex1 Sum(Complex1 x)
            {
                Complex1 y=new Complex1();
                y.im = x.im + this.im;
                y.re = x.re + this.re;
                return y;
            }
            public Complex1 Minus(Complex1 x)
            {
                Complex1 y = new Complex1();
                y.im = this.im- x.im;
                y.re = this.re-x.re;
                return y;
            }
            public Complex1 Proizv(Complex1 x)
            {
                Complex1 y = new Complex1();
                y.re = this.re * x.re - this.im * x.im;
                y.im = this.re * x.im + this.im * x.re;
                return y;
            }
            public string ToString()
            {
                return $"{re}+{im}i";
            }



        }
        #endregion
    }
}
