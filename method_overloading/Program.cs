using System;

namespace method_overloading
{
    class app
    {
        public static void Main()
        {
            int a = 50;
            int b = 50;
            int c = 40;

            app obj = new app();

            obj.function(a, b, c);
            obj.function(a, b);
        }


        public void function(int a, int b, int c)
        {
            int result = a+ b + c;
            Console.WriteLine("Sum of 3 number's is: " + result);
        }

        public void function(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of 2 number's is: " + result);
        }
    }
}