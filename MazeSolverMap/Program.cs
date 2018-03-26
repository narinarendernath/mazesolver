using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolverMap
{
        class Program
        {
            static void Main(string[] args)
            {
                //RUN THE SOLUTION, SEE THE OUTPUT IN CONSOLE
                string strjagged = @"########## 
                                 #A...#...# 
                                 #.#.##.#.# 
                                 #.#.##.#.#
                                 #.#....#B# 
                                 #.#.##.#.#
                                 #....#...# 
                                 ##########";
                string[] jagged = Array.ConvertAll(strjagged.Split('\n'), p => p.Trim());
                string parsedstr;
                for (int i = 0; i < jagged.Length; i++)
                {
                    for (int j = 0; j < jagged.Length; j++)
                    {
                        //Console.WriteLine(jagged[j]);
                        parsedstr = parseArray(jagged, i);
                        string[] parsedArray = parsedstr.Split('\n');
                        for (int k = 0; k < parsedArray.Length; k++)
                        {
                            string str = parsedArray[k];
                            for (int l = 0; l < str.Length; l++)
                            {
                                Console.Write(str[l]);
                            }
                            Console.WriteLine();
                        }



                        Console.ReadLine();
                    }

                }



            }

            private static string parseArray(string[] v, int i)
            {
                string parsed = string.Empty;
                for (int j = 0; j < v.Length; j++)
                {
                    string strvalue = v[j];

                    for (int k = 0; k < strvalue.Length; k++)
                    {
                        if (j <= i)
                        {
                            if (strvalue[k] == '#')
                                parsed = parsed + strvalue[k].ToString();
                            else if (strvalue[k] == '.')
                                parsed = parsed + "@";
                            else if (strvalue[k] == 'A')
                                parsed = parsed + strvalue[k].ToString();
                        }
                        else
                            parsed = parsed + strvalue[k].ToString();

                    }
                    parsed = parsed + "\n";
                }

                return parsed;
            }
        }

    }


