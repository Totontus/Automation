using System;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string Sequence = Console.ReadLine() + " ";
            char[] ChSequence = Sequence.ToCharArray();
            string MaxpPosition = Convert.ToString(ChSequence[0]);
            int MaxValue = 0;
            for (int i = 1; i < Sequence.Length; i++)
            {
                if (MaxpPosition.IndexOf(ChSequence[i]) == -1 && Convert.ToString(ChSequence[i]) != " ") MaxpPosition = MaxpPosition + Convert.ToString(ChSequence[i]);
                else
                {
                    if (MaxValue < MaxpPosition.Length)
                    {
                        MaxValue = MaxpPosition.Length;
                    }
                    if (Convert.ToString(ChSequence[i]) == " ")
                    {
                        if (i++ != Sequence.Length - 1)
                        {
                            MaxpPosition = Convert.ToString(ChSequence[i]);
                        }
                    }
                    else MaxpPosition = Convert.ToString(ChSequence[i]);
                }
            }
            Console.WriteLine(MaxValue);
        }
    }
}
