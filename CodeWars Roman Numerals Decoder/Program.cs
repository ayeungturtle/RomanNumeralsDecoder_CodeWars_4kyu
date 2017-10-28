using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Roman_Numerals_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("II"));
            Console.ReadLine();
        }

        public static int Solution(string input)
        {
            int romAsNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'M':
                        romAsNum += 1000;
                        break;
                    case 'C':
                        if (input[i + 1] == 'M')
                        {
                            romAsNum += 900;
                            i += 1;
                        }
                        else
                        {
                            romAsNum += 100;
                        }
                        break;
                    case 'D':
                        romAsNum += 500;
                        break;
                    case 'X':
                        if (input[i + 1] == 'C')
                        {
                            romAsNum += 90;
                            i += 1;
                        }
                        else if (input[i + 1] == 'L')
                        {
                            romAsNum += 40;
                            i += 1;
                        }
                        else
                        {
                            romAsNum += 10;
                        }
                        break;
                    case 'L':
                        romAsNum += 50;
                        break;
                    case 'I':
                        if (i < input.Length - 1)     //in case this 'I' is the last character in the input, it will not throw an index error
                        {
                            if (input[i + 1] == 'X')
                            {
                                romAsNum += 9;
                                i += 1;
                            }
                            if (input[i + 1] == 'V')
                            {
                                romAsNum += 4;
                                i += 1;
                            }
                            else
                            {
                                romAsNum += 1;
                            }
                        }
                        else
                        {
                            romAsNum += 1;
                        }
                        break;
                    case 'V':
                        romAsNum += 5;
                        break;
                }

            }
            return romAsNum;
        }
    }
}
