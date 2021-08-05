using System;

namespace ProblemSolving
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV")); 
        }


        public static int RomanToInt(string s)
        {
            char[] romans = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] values = new int[] { 1, 5, 10, 50, 100, 500, 1000 };


            char[] input = new char[s.ToCharArray().Length];
            input = s.ToCharArray();


            var result = 0;
            var preIndex = 0;
            

            foreach (char a in input)
            {
                 int index = Array.IndexOf(romans, a);
                 int value = values[index];

                if (result == 0)
                {
                    result += value;
                }
                else
                {
                    if (values[preIndex] < value)
                    {
                        int cal = value - values[preIndex];
                        result += cal;
                        result -= values[preIndex];
                    }
                    else
                    {
                        result += value;
                    }

                }

                preIndex = index;
            }

                return result;
            }

        }
    }

