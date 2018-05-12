using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string s = Console.ReadLine();
            bool complete = false;

            while (complete == false)
            {
                if (s.Length > 1)
                {
                    for (int i = 1; i < s.Length;)
                    {
                        if (s[i] == s[i - 1])
                        {
                            s = s.Remove(i - 1, 2);
                            i = 1;
                        }
                        else
                        { 
                            i = i+1;
                        }
                    }
                    complete = true;
                }
                else
                {
                    complete = true;
                }
            }

            Console.WriteLine("Your result = " + s);
            Console.ReadLine();
        }
    }
}
