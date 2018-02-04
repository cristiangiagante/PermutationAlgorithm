using System;
using System.Linq;
using System.Text;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = new char[] { 'a', 'b', 'c', 'd', 'b', 'a', 'd', 'd', 'a' };
            char[] b = new char[] { 'b', 'a', 'd','d' };
            Console.WriteLine(CheckPermutation(a, b));
            Console.ReadLine();
        }

        private static string CheckPermutation(char[] a, char[] b)
        {
            var limit = b.Length - 1;
            StringBuilder tempStringComparer = new StringBuilder();
            int result = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                bool match = true;
                if (b.Contains(a[i]))
                {
                    for (int j = 0; j <= limit && a.Length - 1 >= i + limit; j++)
                    {
                        tempStringComparer.Append(a[i + j]);
                    }
                    for (int k = 0; k <= limit && a.Length - 1 >= i + limit; k++)
                    {
                        if (tempStringComparer.ToString().IndexOf(b[k]).Equals(-1))
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match && !string.IsNullOrEmpty(tempStringComparer.ToString()))
                        result++;
                    tempStringComparer.Clear();
                }
            }
            return result.ToString();
        }
    }
}
