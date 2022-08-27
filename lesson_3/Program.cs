using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3
{

    public struct Complex
    {
        //Мнимая часть
        public double im;
        //Действительная часть
        public double re;


        public Complex Plus(Complex x)
        {

            Complex y = new Complex();
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        public Complex Minus(Complex x)
        {

            Complex y = new Complex();
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        public static Complex Plus(Complex complex1, Complex complex2) { 
            Complex res= new Complex();
            res.re = complex1.re + complex2.re;
            res.im = complex1.im + complex2.im;
            return res;
        }

        public static Complex Minus(Complex complex1, Complex complex2)
        {
            Complex res = new Complex();
            res.re = complex1.re - complex2.re;
            res.im = complex1.im - complex2.im;
            return res;
        }


        public override string ToString()
        {
            string s = "";
            switch (Math.Sign(im))
            {
                case -1:
                    s = $"{re}-{Math.Abs(im)}i";
                    break;

                case 1:
                    s = $"{re}+{im}i";
                    break;

                case 0:
                    s = $"{re}+{im}i";
                    break;
            }
            return s;
        }

    }


    public class ComplexClass
    {
        //Мнимая часть
        public double _im;
        //Действительная часть
        public double _re;

        public ComplexClass(double re, double im)
        {
            _im = im;
            _re = re;
        }

        public ComplexClass() { }

        public static ComplexClass Plus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass();
            res._re = complex1._re + complex2._re;
            res._im = complex1._im + complex2._im;
            return res;
        }
        public static ComplexClass Minus(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass();
            res._re = complex1._re - complex2._re;
            res._im = complex1._im - complex2._im;
            return res;
        }

        public static ComplexClass Multiplication(ComplexClass complex1, ComplexClass complex2)
        {
            ComplexClass res = new ComplexClass();
            res._re = complex1._re * complex2._re - complex1._im*complex2._im;
            res._im = complex1._re * complex2._im + complex1._im*complex2._re;
            return res;
        }

        public override string ToString()
        {
            string s = "";
            switch (Math.Sign(_im))
            {
                case -1:
                    s = $"{_re}-{Math.Abs(_im)}i";
                    break;

                case 1:
                    s = $"{_re}+{_im}i";
                    break;

                case 0:
                    s = $"{_re}+{_im}i";
                    break;
            }
            return s;
        }

    }

    
    internal class Program
    {
        private static string task(int task_1)
        {
            string indent = new string('=', System.Console.WindowWidth);
            string fio = "Латышев Никита Анатольевич";
            string task_2 = "";
            switch (task_1)
            {
                case 1:
                    task_2 = fio + "\nЗадание 1.\nа) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.\nб) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\nв) Добавить диалог с использованием switch демонстрирующий работу класса.\n";
                    System.Console.Write(indent);
                    System.Console.Write(task_2);
                    System.Console.Write(indent);

                    break;

                case 2:
                    task_2 = fio + "\nЗадание 2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.\n";
                    System.Console.Write(indent);
                    System.Console.Write(task_2);
                    System.Console.Write(indent);
                    break;
            }
            return task_2;
        }

        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.Write("Введите от 1 до 2: ");
                int cs = int.Parse(Console.ReadLine());
                switch (cs) {
                    case 1:
                        task(cs);
                        Console.Write("Введите действительную часть  первого комплексного числа: ");
                        double re1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите мнимую часть первого комплексного числа: ");
                        double im1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите действительную часть второго комплексного числа: ");
                        double re2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите мнимую часть второго комплексного числа: ");
                        double im2 = double.Parse(Console.ReadLine());
                        while (true) {
                            Console.WriteLine("Для проверки структуры введите 1, для класса 2:");
                            int i = int.Parse(Console.ReadLine());
                            switch (i) {

                                case 1:
                                    Complex complex1 = new Complex();
                                    complex1.re = re1;
                                    complex1.im = im1;
                                    Complex complex2=new Complex();
                                    complex2.re = re2;
                                    complex2.im = im2;
                                    Complex complex3=new Complex();
                                    complex3 = complex1.Plus(complex2);
                                    Complex complex4 =Complex.Minus(complex1,complex2);
                                    Console.WriteLine($"Результат работы с комплексными числами {complex1} и {complex2}");
                                    Console.WriteLine($"Сумма комплексных чисел {complex3}");
                                    Console.WriteLine($"Вычитание комплексных чисел {complex4}");
                                    break;
                                case 2:
                                    ComplexClass complexClass1 = new ComplexClass(re1, im1);
                                    ComplexClass complexClass2 = new ComplexClass(re2, im2);
                                    ComplexClass complexClass3 = ComplexClass.Plus(complexClass1, complexClass2);
                                    ComplexClass complexClass4 = ComplexClass.Minus(complexClass1, complexClass2);
                                    ComplexClass complexClass5 = ComplexClass.Multiplication(complexClass1, complexClass2);
                                    Console.WriteLine($"Результат работы с комплексными числами {complexClass1} и {complexClass2}");
                                    Console.WriteLine($"Сумма комплексных чисел {complexClass3}");
                                    Console.WriteLine($"Вычитание комплексных чисел {complexClass4}");
                                    Console.WriteLine($"Вычитание комплексных чисел {complexClass5}");
                                    break;
                                default: return;
                            }

                        }
                        break;


                    case 2:
                        task(cs);
                        int result = 0;
                        var numbers = new List<int>();

                        bool check = true;
                        do
                        {
                            Console.Write("Введите число:");
                            check = int.TryParse(System.Console.ReadLine(), out int number);
                            if (check)
                            {
                                if (number > 0 && number % 2 == 1)
                                {
                                    result += number;
                                    numbers.Add(number);
                                }
                                else if (number == 0)
                                {
                                    check = false;
                                }
                            }
                        }
                        while (check);

                        string s = "";
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            s += ($"{numbers[i]};");
                        }
                        System.Console.Write("\nНечетные и положительные числа: " + s);
                        Console.Write($"\nСумма нечетных и положительных чисел =  {result};");
                        Console.ReadLine();
                        break;
                    default:
                        return;
                }
            }

            Console.ReadLine();
        }
    }
}
