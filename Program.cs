using System.Globalization;

namespace twoDimentionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 2, 3 } };
            int[,] num1 = new int[4, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 }, { 10, 11} };

            /*foreach(int i in num)
             {
                 Console.WriteLine(i);
             }*/
            int sumItemsInOneRow = 0;
            int sumAllItemsInArray = 0;
            float averageItemInOneRow = 0;
            int number = 1;
            for (int i =0; i<num1.GetLength(0); i++)
            {
                for (int j = 0; j < num1.GetLength(1); j++)
                {
                    Console.WriteLine(num1[i, j]);

                    sumItemsInOneRow = sumItemsInOneRow + num1[i, j];//here to calculate total items in one practic{} or one a row
                    sumAllItemsInArray = sumAllItemsInArray + num1[i, j];//here to calculate total of items in array(all items in a rows and colums)
                    number++;


                }
               
                Console.WriteLine("total sum of this row : " + sumItemsInOneRow);//i put print here because one row will be done after this pracit

                averageItemInOneRow = sumItemsInOneRow / 2;
                Console.WriteLine("the average of this row is " + averageItemInOneRow);

                sumItemsInOneRow = 0;//and give this variable zero again to re-calculate for another row.if i don't give it zero here that means will continue calculate for next row with previous row.
                number = 0;

            }

            Console.WriteLine("the total calculate of all items in all rows and colums is " + sumAllItemsInArray);//i put print here for calculate all items in array in outside of both for-Loop to give me finally of sum.
            
        }
    }
}