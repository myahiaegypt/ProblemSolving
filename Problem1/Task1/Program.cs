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
        StartOver: Console.WriteLine("Please enter the matrix dimension, or Enter x to exit: ");
            strDimension= Console.ReadLine();
            int intdimension;
            int[,] intmatrix;
            String[] SplitRow;
            int Diagonal1 = 0;
            int Diagonal2 = 0;
            int absDifference = 0;
            int j = 0;
            int i = 0;
            if (strDimension == "x")
            {
                Environment.Exit(0);
            }
            try
            {
                intdimension = Convert.ToInt32(strDimension);
                intmatrix = new int[intdimension, intdimension];
                for (i = 1; i < intdimension + 1; i++)
                {
                StartInside: Console.WriteLine("Please enter numbers between -100 and 100 with space separated, or press s to start over: ");
                    Console.WriteLine("row: " + i + ":");
                    lineNumbers = Console.ReadLine();
                    if (lineNumbers == "s")
                    {
                        goto StartOver;
                    }
                    try
                    {
                        string[] numberList = lineNumbers.Split(' ');
                        if (numberList.Length != intdimension)
                        {
                            Console.WriteLine("Please enter " + intdimension + "  numbers between -100 and 100 separated by space");
                            j = 0;
                            //i = i - 1;
                            goto StartInside;
                        }
                        for (j = 0; j < numberList.Length; j++)
                        {
                            intmatrix[i - 1, j] = Convert.ToInt32(numberList[j]);
                            //Console.WriteLine("values: " + intmatrix[i - 1, j]);
                            if (intmatrix[i - 1, j] <-100 || intmatrix[i - 1, j] >100)
                            {
                                Console.WriteLine("Please use numbers between -100 and 100, enter the last line only, or press s to start from beginning");
                                j = 0;
                                //i = i - 1;

                                goto StartInside;
                            }
                            if (i - 1 == j)
                            {
                                Diagonal1 = Diagonal1 + intmatrix[i - 1, j];
                            }
                            if (i + j == intdimension)
                            {
                                Diagonal2 = Diagonal2 + intmatrix[i - 1, j];
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        j = 0;
                        Console.WriteLine("Please use numbers only, enter the last line only");
                        goto StartInside;
                    }
                }
            }
            catch(Exception e)
            {
                j = 0;
                Console.WriteLine("Please type numbers only");
                goto StartOver;
            }
            Diagonal1 = 0;
            Diagonal2 = 0;
            for (int k = 0; k < intdimension; k++)
            {
                Diagonal1=Diagonal1+ intmatrix[k, k];
                Diagonal2 = Diagonal2 + intmatrix[k, intdimension-1 - k];
            }
            Console.WriteLine("Diagonal 1 is : " + Diagonal1);
            Console.WriteLine("Diagonal 2 is : " + Diagonal2);
            Console.WriteLine("AbsDifference is : " + Math.Abs(Diagonal1-Diagonal2));
            strDimension = Console.ReadLine();


        }
    }
}
