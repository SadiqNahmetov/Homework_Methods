using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // 1) Verilmiş n -ədədinin 3 - ə və 7 - ə bölünüb - bölünməməsini tapı

                //    Divide3And7(21);

                // 2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
                //CalculateSum(22, 44);

                // 3) Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.

                //SumOfOdds(3, 57);

                // 4) Verilmish arrayin icindeki tek ededlerin cemini tapin

                //int[] num = { 1, 5, 9, 4, 12, 6, 15, 16, 17};
                //var result = SumOfOddsArr(num);
                //Console.WriteLine(result);

                // 5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

                int[] num = { 2, 3, 4, 8, 12, 15, 17, 24, 44 };
                var result = SumOfEvenArr(num);
                Console.WriteLine(result);


                // 6) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
                //SimpleComposite(23);


            }

            // 1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapı

            //static void Divide3And7(int n)
            //{
            //    if (n % 3 == 0 && n %7 == 0)
            //    {
            //        Console.WriteLine("Dividable");
            //    }
            //    else
            //      Console.WriteLine("Not Dividable");
            //  }    

            //2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

            //static void CalculateSum(int n, int m)
            //{
            //    if (n % 2 == 0 && m % 2 == 0)
            //    {
            //        Console.WriteLine(n + m);
            //    }
            //    else
            //        Console.WriteLine("Numbers are not even");
            //}

            // 3) Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.

            //static void SumOfOdds(int n, int m)
            //{
            //    int sum = 0;
            //    for (int i = n; i < m; i++)
            //    {
            //        if (i % 2 == 1 && i > n)
            //        {
            //            sum += i;
            //        }
            //    }
            //    Console.WriteLine(sum);


            // 4) Verilmish arrayin icindeki tek ededlerin cemini tapin

            //  static int SumOfOddsArr(int[] arr)
            //  { 
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if(arr[i] %2 == 1)
            //        {
            //            sum += arr[i];
            //        }
            //    }
            //    return sum;                                                                                                                                                                                                                                                                                                       
            //}

            // 5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

            static int SumOfEvenArr(int[] arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                        count++;

                }
                return count;
            }

            // 6) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

            //static void SimpleComposite(int n)
            //{
            //    int result = 0;
            //    for (int i = 1; i <= n / 2; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            result++;
            //        }
            //    }
            //    if (result > 1)
            //    {
            //        Console.WriteLine("Composite");
            //    }
            //    else
            //        Console.WriteLine("Simple");
            //}
        }
    }
}
