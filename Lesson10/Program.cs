using System;

namespace Lesson10
{
    static class Calc
    {
        public static T Add<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        public static T Minus<T>(T a, T b)
        {
            return (dynamic)a - (dynamic)b;
        }
        public static T Product<T>(T a, T b)
        {
            return (dynamic)a * (dynamic)b;
        }
        public static T Divide<T>(T a, T b)
        {
            return (dynamic)a / (dynamic)b;
        }
    }
    class Program
    {

        delegate T Operation<T>(T a, T b);
        static void Main(string[] args)
        {

            Operation<int> add = Calc.Add<int>;
            Operation<int> minus = Calc.Minus<int>;
            Operation<int> product = Calc.Product<int>;
            Operation<int> divide = Calc.Divide<int>;


            Console.Write("Enter a value for A = ");
            var A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for B = ");
            var B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose an oparation " );
            Console.Write("[+, -, *, /]");
            var x = Console.ReadLine(); 

            if (x == "+")
                Console.WriteLine(add.Invoke(A,B));
            else if (x == "-")
                Console.WriteLine(minus.Invoke(A,B));
            else if (x == "*")
                Console.WriteLine(product.Invoke(A,B));
            else if (x == "/")
                Console.WriteLine(divide.Invoke(A,B));
            else
                Console.WriteLine("Wrong oparation input");
        }
    }
}
