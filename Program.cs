using System;

namespace pogrujenie2
{
    class Program
    {

        static void PrintArray(int[,] array)
        {
          
            for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                     {
                        Console.Write($".. {array[i,j]} ..");
                     }
            }
        }


        static void Main(string[] args)
        {

            int[,] array = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };                       
            int[] tempArray = new int[9];
            int index = 0;

            for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                     {
                        tempArray[index] = array[i,j];
                        index++;
                     }
            }
            

           Array.Sort(tempArray);


           index = 0;

            for (int i = 0; i < array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                     {
                        array[i,j] = tempArray[index];
                        index++;
                     }
            }
            
            PrintArray(array);
        }
    }
}
