using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strDimension;
            String lineNumbers;
            int intdimension = 5;
            int[,] intmatrix = new int[intdimension, intdimension];
            int rowsmoves = 0;
            int columnmoves = 0;
            int Allmoves = 0;
            bool Foundone = false;
        StartOver:    int i = 0;
            int j = 0;
            for ( i = 1; i < intdimension + 1; i++)
            {
                 StartInside:  Console.WriteLine("Please type x to exit, enter zero or one separated by space in lines: " );
                Console.WriteLine("Row #" + i + ":");
                lineNumbers = Console.ReadLine();
                if (lineNumbers == "x")
                {
                    Environment.Exit(0);
                }
                if (lineNumbers=="s")
                {
                    goto StartOver;
                }
                try
                {

                    string[] numberList = lineNumbers.Split(' ');
                    if (numberList.Length != 5)
                    {
                        Console.WriteLine("Please enter 5 numbers separated by space");
                        j = 0;
                        //i = i - 1;
                        goto StartInside;
                    }
                    for ( j = 0; j < numberList.Length; j++)
                    {
                        intmatrix[i - 1, j] = Convert.ToInt32(numberList[j]);
                        if (intmatrix[i - 1, j]!=0 && intmatrix[i - 1, j]!=1)
                        {
                            Console.WriteLine("Please use only zero or one, enter the last line only, or press s to start from beginning");
                            j = 0;
                            //i = i - 1;

                            goto StartInside;
                        }
                        //Console.WriteLine("values: " + intmatrix[i - 1, j]);
                        if (intmatrix[i - 1, j] == 1)
                        {
                            if (Foundone == false)
                            {
                                rowsmoves = Math.Abs(2 - (i - 1));
                                columnmoves = Math.Abs(2 - j);
                                Foundone = true;
                            }
                            else 
                            {
                                Console.WriteLine(" you entered one before, you can press s to start over or enter the last line only");
                                j = 0;
                                //i = i - 1;
                                goto StartInside;
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                    j = 0;
                    //i = i - 1;
                    Console.WriteLine("Please use only zero or one, enter the last line only, or press s to start from beginning");
                    goto StartInside;
                }
            }
            Allmoves = rowsmoves + columnmoves;
            Console.WriteLine("rowmoves is : " + rowsmoves);
            Console.WriteLine("columnmoves is : " + columnmoves);
            Console.WriteLine("AllMoves is : " +Allmoves);
            strDimension = Console.ReadLine();


        }
    }
}
