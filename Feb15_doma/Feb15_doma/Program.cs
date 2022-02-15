using System;

namespace Feb15_doma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            Console.WriteLine("eded daxil edin.");
            string a = Console.ReadLine();
            int num = int.Parse(a);
            
            Console.WriteLine("eded daxil edin.");
            string b = Console.ReadLine();
            int num1 = int.Parse(b);
            
            Console.WriteLine("eded daxil edin.");
            string c = Console.ReadLine();
            int num2 = int.Parse(c);
            Console.WriteLine("Teshekkur edirik, biz size en boyuk ededi qaytaracayiq!");

            Console.WriteLine(a, b, c);
            #endregion

            #region Task 2

            Console.WriteLine("Ededi Daxil Edin:");
            string number = Console.ReadLine();
            int number1 = int.Parse(number);

            Console.WriteLine(SumOfNumbers(number1));
            #endregion

            #region Task 3

            Console.WriteLine("Salam, iki eded alin ucuncusu hediyye.");
            string goodscount = Console.ReadLine();
            int aa = int.Parse(goodscount);
            int[] arr = new int[aa];
            
            Console.WriteLine("Diger mehsulu daxil edin.");
            string goodscount1 = Console.ReadLine();
            int bb = int.Parse(goodscount1);
            int[] arr1 = new int[bb];
            
            Console.WriteLine("son mehsulu daxil edin.");
            string goodscount2 = Console.ReadLine();
            int cc = int.Parse(goodscount2);
            int[] arr2 = new int[cc];
            
            Console.WriteLine(StoreCoupons(aa, bb, cc));

            #endregion

        }
        static int SumOfNumbers(int number1) 
        {
            int n;
            int Sum = 0;
            while (number1 > 0)
            {
                n = number1 % 10;
                number1 /= 10;
                Sum += n;
            }
            return Sum;
        }

        static int BiggestNumber(int a, int b, int c)
        {
            if (a > c && a > b)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else return c;
        }

        static int StoreCoupons(int aa, int bb, int cc)
        {
            if (aa < bb && aa < cc)
            {
                return cc + bb;
            }
            else if (bb < aa && bb < cc)
            {
                return aa + cc;
            }
            else return aa + bb;
        }
    }
}
