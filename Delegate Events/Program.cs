using System;
using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;

namespace Delegates_Event
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////task:1
            //Print print = ConsolePrint;
            //print(6);


            ////task:2
            //Func<int,int,int > power = PowerNumber;
            //Console.WriteLine("Birinci reqemi daxil edin: ");
            //int.TryParse(Console.ReadLine(), out int number1);

            //Console.WriteLine("Ikinci reqemi daxil edin: ");
            //int.TryParse(Console.ReadLine(), out int number2);

            //Console.WriteLine(number1 * number2);


            ////task:3
            //Predicate<int> function = IsEven;
            //List<int> numbers = new List<int>() { 3,9,6,16,19,23,20,94,106 };
            //CutReqemler(numbers, function);


            ////Task:4
            //Action<int> func = AddNumber;
            //List<int> numbers = new List<int> { 13,7,99,56,0,10 };
            //ChangeList(numbers, func);


            ////task:5
            //Action<int> action1 = Add;
            //Action<int> action2 = Sum;
            //List<Action<int>> actions = new List<Action<int>>() { action1, action2 };
            //Console.Write("Add: ");
            //Add(5);
            //Console.WriteLine();
            //Console.Write("Sum: ");
            //Sum(2);
            //Console.WriteLine();


            ////task:6
            //Predicate<string> name = NameLength;
            //List<string> names = new List<string> { "Jennie", "Taehyung", "Kamran", "Nigar", "Ahu" };
            //NamesFilter(names, name);


        }

        ////task:1
        //public delegate void Print(int nam);

        //static void ConsolePrint(int i)
        //{
        //    Console.WriteLine(i);
        //}


        ////task:2
        //public static int PowerNumber(int number1,int number2)
        //{
        //    return number1 * number2;
        //}


        ////task:3
        //public static void CutReqemler(List<int> numbers, Predicate<int> function)
        //{
        //    foreach (var item in numbers)
        //    {
        //        if (function(item))
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}
        //public static bool IsEven(int item)
        //{
        //    return item % 2 == 0;
        //}


        ////task:4
        //public static void ChangeList(List<int> numbers, Action<int> func)
        //{
        //    foreach (var num in numbers)
        //    {
        //        func(num);
        //    }
        //}
        //static void AddNumber(int num)
        //{

        //    num = num + 1;
        //    Console.WriteLine(num);
        //}


        ////task:5
        //public static void Add(int num1)
        //{
        //    Console.WriteLine(num1 * num1);
        //}
        //public static void Sum(int num2)
        //{
        //    Console.WriteLine(num2+num2);
        //}


        ////task:6
        //public static void NamesFilter(List<string> names, Predicate<string> name)
        //{
        //    foreach (var i in names)
        //    {
        //        if (NameLength(i))
        //        {
        //            Console.Write(i+ ',' );
        //        }
        //    }
        //}
        //public static bool NameLength(string i)
        //{
        //    if (i.Length >= 6)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}