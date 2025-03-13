using System.Security.Cryptography;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Ədədlərdən ibarət arrayın ən kiçik elementini tapın
            //int[] num = { 3, 7, 9, 8, 1, 4, 45 };
            //int min = num[0];
            //for (int i = 1; i < num.Length; i++)
            //{
            //    if (num[i] < min)
            //    {
            //        min = num[i];
            //    }
            //}
            //Console.WriteLine(min);
            #endregion
            #region Task2
            //Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm
            //int[] num = { 1, 6, 2, 9, 13, 15 };
            //int sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task3
            //Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran algorithmmisal
            //int[] num = { 23, 47, 7, 8, 11, 2, 22, 1 };
            //int max = num[0];
            //int min = num[1];
            //int index_max=0;
            //int index_min = 0;
            //for(int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] > max)
            //    {
            //        max = num[i];
            //        index_max = i;
            //    }
            //        if (num[i]<min)
            //        {
            //            min = num[i];
            //            index_min= i;
            //        }


            //}
            //Console.WriteLine("maksimum elementin indeksi:"+index_max);
            //Console.WriteLine("minimum elementin indeksi:"+index_min);
            #endregion
            #region Task4
            //Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal
            int[] num = { 4, 2, 23, 44, 1, 12, 21, 7 };

            for (int i = 0; i < num.Length; i++)
            {
                bool murekkeb = true;
                if (num[i] > 1)
                {
                    if (num[i] == 2)
                    {
                        continue;
                    }
                    for (int j = 2; j < num[i]; j++)
                    {
                        if (num[i] % j == 0)
                        {
                            murekkeb = true;
                            break;
                        }
                    }
                }


                if (murekkeb)
                {

                    Console.WriteLine(num[i]);
                }
            }
            #endregion
        }
    }
}
