using System;

namespace MaxSumNaiveMethod
{
    class Program
    {
        public int[] rotateArray(int[] arr)
        {
            int[] tempArray = new int[arr.Length];
            int firstValue = arr[0];
            int j = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                tempArray[j] = arr[i];
                j++;
            }
            tempArray[arr.Length - 1] = firstValue;

            return tempArray;
        }

        public int sumOfArray(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i] * i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 8, 3, 1, 2 };
            int sum = program.sumOfArray(arr);
            int tempSum = 0;
            int[] tempArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                tempArray = program.rotateArray(arr);
                tempSum = program.sumOfArray(tempArray);

                if (tempSum > sum)
                {
                    sum = tempSum;
                }
                
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = tempArray[j];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
