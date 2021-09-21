using System;

namespace NumeralSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            string systemBase = "23456789ABCDEFGHIJK";
            char[] ch = systemBase.ToCharArray();
            string Output = "";
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 18)
            {
                for (int i = 0; i < number / 18; i++)
                {
                    Output = Output + "K";
                }
                if (number % 18 != 0) Output = Output + ch[number % 18 - 1];
            }
            else Output = Convert.ToString(ch[number]);
            Console.WriteLine(Output);
        }
    }
}
