using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdansShortcuts
{
    public class UserInput
    {
        /// <summary>
        /// Nuggets!!!!!!!!!!!!!!!!!!!!!!
        /// </summary>
        public static void nuggets()
        {
            while (true) Console.WriteLine("i ate your nuggets");
        }
        static void options(int option, int counter, string add)
        {
            if (option == 2)
            { Console.WriteLine("Are you even listenning?! please type " + add + "!"); }
            else if (option == 3)
            { Console.WriteLine("Hmmmm... im sorrounded by idiots, I'm begging you! please type " + add + "!"); }
            else if (option == 4)
            { Console.WriteLine("Don't mess with me, I need " + add + "!"); }
            else if (option == 5)
            { Console.WriteLine("God, all i need is " + add + ",Just type " + add + "!"); }
            else if (option == 6)
            { Console.WriteLine("Ughhh someone please save me!! That idiot won't type " + add + "..."); }
            else if (option == 7)
            { Console.WriteLine("There's a sad story about a kid who wanted " + add + ", And you have just ruined his dream"); }
            else if (option == 8)
            { Console.WriteLine("I'm sad now, Make me happy by typing " + add + " :("); }
            else if (option == 9)
            { Console.WriteLine("Dude i've asked you " + counter + " times already, please just do it and type " + add); }
            else if (option == 10)
            { Console.WriteLine("Ugh, not cool.. It's already " + counter + " times that I've asked you, Please just do it and give me " + add + " :)"); }
            else if (option == 11)
            { Console.WriteLine("Do me a favor and type " + add); }
            else if (option == 12)
            { Console.WriteLine("Even though you're annoying, Lets try to be friends. As a gift you can give me " + add); }
            else if (option == 13)
            { Console.WriteLine("Hey im sent here by the FBI, And i need you to give me " + add); }
            else if (option == 14)
            { Console.WriteLine("The world will end unless you give me " + add); }
            else if (option == 15)
            { Console.WriteLine("You're like the worst possible person, You're torturing a program\ntype " + add); }
            else if (option == 16)
            { Console.WriteLine("Don't be rude and type " + add); }
            else if (option == 17)
            { Console.WriteLine("It feels like talking to a wall, I've asked " + counter + " times already\nim begging for " + add); }
            else if (option == 18)
            { Console.WriteLine("I hate my life, Why do i need to talk with this guy?\nhe won't type " + add + " no matter what i do"); }
            else if (option == 19)
            { Console.WriteLine("It's just " + add + "... not too hard, go on and type it"); }
            else if (option == 20)
            { Console.WriteLine("Im disappointed, I could have never imagined that I'll end my life begging to a piece of bones and flash for " + add); }
        }
        public static int Int(string add)
        {
            int output, option = 0, counter = 1;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = int.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = int.TryParse(get, out output);
            }
            return output;
        }
        public static double Double(string add)
        {
            int option = 0, counter = 1;
            double output;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = double.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = double.TryParse(get, out output);
            }
            return output;
        }
        public static long Long(string add)
        {
            int option = 0, counter = 1;
            long output;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = long.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = long.TryParse(get, out output);
            }
            return output;
        }
        public static ulong Ulong(string add)
        {
            int option = 0, counter = 1;
            ulong output;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = ulong.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = ulong.TryParse(get, out output);
            }
            return output;
        }
        public static float Float(string add)
        {
            int option = 0, counter = 1;
            float output;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = float.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = float.TryParse(get, out output);
            }
            return output;
        }
        public static string String(string add)
        {
            int option = 0, counter = 1;
            string output;
            Console.WriteLine("please type " + add);
            output = Console.ReadLine();
            bool good = !string.IsNullOrEmpty(output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }
                if (option > 1) option = Calc.Randomizer(2, 20);
                output = Console.ReadLine();
                good = !string.IsNullOrEmpty(output);
            }
            return output;
        }
        public static char Char(string add)
        {
            int option = 0, counter = 1;
            char output;
            string get;
            Console.WriteLine("please type " + add);
            get = Console.ReadLine();
            bool good = char.TryParse(get, out output);
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                get = Console.ReadLine();
                good = char.TryParse(get, out output);
            }
            return output;
        }
        public static T Object<T>(string add)
        {
            int option = 0, counter = 1;
            T get = default(T);
            Console.WriteLine("please type " + add);
            bool good = true;
            try
            {
                get = (T)Convert.ChangeType(Console.ReadLine() as object, typeof(T));
            }
            catch { good = false; }
            while (!good)
            {
                counter++;
                options(option, counter, add);
                if (option == 0)
                { Console.WriteLine("Please actually type " + add); option++; }
                else if (option == 1)
                { Console.WriteLine("Not kidding, type " + add + "!"); option++; }

                if (option > 1) option = Calc.Randomizer(2, 20);
                try { get = (T)Convert.ChangeType(Console.ReadLine() as object, typeof(T)); }
                catch { good = false; }

            }
            return get;
        }
        public static void Array(int[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Int(add + " for index " + i); }
        }
        public static void Array(double[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Double(add + " for index " + i); }
        }
        public static void Array(long[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Long(add + " for index " + i); }
        }
        public static void Array(ulong[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Ulong(add + " for index " + i); }
        }
        public static void Array(float[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Float(add + " for index " + i); }
        }
        public static void Array(string[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = String(add + " for index " + i); }
        }
        public static void Array<T>(T[] array, string add)
        {
            for (int i = 0; i < array.Length; i++)
            { array[i] = Object<T>(array.GetType().ToString()); }
        }
        public static void Matrix(int[,] array, string add)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Int(add + " for index [" + i + ", " + j + "]");
            }
        }
        public static void Matrix(double[,] Matrix, string add)
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                        Matrix[i, j] = Double(add + " for index [" + i + ", " + j + "]");
                }
            }
        public static void Matrix(long[,] Matrix, string add)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = Long(add + " for index [" + i + ", " + j + "]");
            }
        }
        public static void Matrix(ulong[,] Matrix, string add)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = Ulong(add + " for index [" + i + ", " + j + "]");
            }
        }
        public static void Matrix(float[,] Matrix, string add)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = Float(add + " for index [" + i + ", " + j + "]");
            }
        }
        public static void Matrix(string[,] Matrix, string add)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = String(add + " for index [" + i + ", " + j + "]");
            }
        }
        public static void Matrix(char[,] Matrix, string add)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    Matrix[i, j] = Char(add + " for index [" + i + ", " + j + "]");
            }
        }
    }
}
