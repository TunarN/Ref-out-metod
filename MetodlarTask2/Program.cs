using System;

namespace MetodlarTask2
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] nums = { 3, 5, 9, 7, 8, 1 };
			MinMaxArraySwap(ref nums);
			foreach (int item in nums)
			{
				Console.WriteLine(item);
			}
		}
		static void MinMaxArraySwap(ref int[] num)
		{

			int min = 0;
			int max = 0;
			for (int i = 0; i < num.Length; i++)
			{
				if (num[min] > num[i])
					min = i;
				if (num[max] < num[i])
					max = i;
			}
			int temp = num[min];
			num[min] = num[max];
			num[max] = temp;

		}
    }
}
