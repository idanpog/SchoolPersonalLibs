using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdansShortcuts
{
    public class Calc
    {
        static void Inc(ref int Num)
        {
            Num++;
        }
        static int maxN(double sum)
        {
            for (double i = 2; i <= sum; i++)
            {
                double a = (sum / i) - (i / 2) + 0.5;
                if ((int)a == a) return (int)i;
            }
            return -1;
        }
        static int newFunction(double sum)
        {
            for (double i = 2; i <= sum; i++)
            {
                double a = (sum / i) - (i / 2) + 0.5;
                if ((int)a == a) return (int)a;
            }
            return -1;
        }
        static Random random = new Random();
        public static int Randomizer(int num1, int num2)
        {
            int bignum, smallnum;
            smallnum = Math.Min(num1, num2);
            bignum = Math.Max(num1, num2);
            int output = random.Next(smallnum, bignum + 1);
            return output;
        }
        public static T Flip<T>(T num)
        {
            string ToFlip = num.ToString();
            string Result = "";
            for (int i = 1; i <= ToFlip.Length; i++)
            {
                Result += ToFlip[ToFlip.Length - i];
            }
            return (T)Convert.ChangeType(Result,typeof(T));
        }
        public static int DigCount<T> (T n)
        {
            return n.ToString().Length;
        }
        public static int DigSum<T>(T n)
        {
            string NotANum = n.ToString();
            NotANum = NotANum.Replace('.','0');
            ulong Num = ulong.Parse(NotANum);
            ulong counter = 0;
            while (Num != 0)
            {
                counter += Num % 10;
                Num /= 10;
            }
            return (int)counter;
        }
        public static string Fibonacci(int n)
        {
            int num1 = 1, num2 = 0, current = 0;
            string output = "";
            for (int i = n; i > 0; i--)
            {
                if ((i == n) && (i != 1))
                    output += "1 ,";
                else
                {
                    current = num1 + num2;
                    num2 = num1;
                    num1 = current;
                    output += current;
                    if (i != 1)
                        output += ", ";
                }
            }
            return output;
        }
        public static int LettersToNumbers(char letter)
        {
            if (letter >= 'a' && letter <= 'z')
                return (int)letter - (int)'a' + 1;
            else if (letter >= 'A' && letter <= 'Z')
                return (int)letter - (int)'A' + 1;
            else return 0;
        }
        public static void numseq(ulong num)
        {
            if (num % 2 == 1)
            { Console.WriteLine(num / 2 + " + " + ((num / 2) + 1) + " = " + num); }
            else
            {
                int start = newFunction(num);
                if (start != -1)
                {
                    int max = maxN(num);
                    for (int i = 0; i < max; i++)
                    {
                        if (i > 0)
                            Console.Write("+");
                        Console.Write(start + i);
                    }
                    Console.WriteLine("=" + num);
                }
                else
                { Console.WriteLine("can't find a matching sequance"); }
            }
        }
        public static bool Contains(string String, char Char)
        {
            return String.ToLower().Contains(Char.ToLower(Char));
        }
        public static double SecondsToYears(double Seconds)
        {
            return (Seconds / (60 * 60 * 24 * 365));
        }
    }
}
