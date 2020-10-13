using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j ="";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
            }
            Console.WriteLine("Outside the for looop for j:" + j);
            Console.WriteLine("Outside the for looop for inner k:" + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething(); //Can only call the public method from here not the private string helperMethod
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("The value of outer k:" + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World";
        }
    }
}
