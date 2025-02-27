namespace zad4
{
    using System;
    class Program
    {
        static void Main()
        {
            int[] arr = { 4, 2, 7, 3, 9, 1, 5 };

            Console.WriteLine("Първоначален масив:");
            PrintArray(arr);

            int target = 7;
            int index = LinearSearchWithMoveToFront(arr, target);

            if (index != -1)
            {
                Console.WriteLine($"\nЕлементът {target} беше намерен на индекс {index}.");
                Console.WriteLine("Масив след преместването на елемента в началото:");
                PrintArray(arr);
            }
            else
            {
                Console.WriteLine($"\nЕлементът {target} не беше намерен.");
            }
        }

        static int LinearSearchWithMoveToFront(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    if (i > 0)
                    {
                        int temp = arr[i];
                        for (int j = i; j > 0; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[0] = temp;
                    }
                    return i;
                }
            }
            return -1; 
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}