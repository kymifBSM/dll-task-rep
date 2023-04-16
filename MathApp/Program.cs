using System;
using MathFunc;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = new double[10];

            Console.WriteLine("Пишите по одному значению: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Значение {i+1}: ");
                nums[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum, product;
            Class1.SumProductFunc(nums, out sum, out product);
            Console.WriteLine("Сумма = {0}", sum);
            Console.WriteLine("Произведение = {0}", product);
            Console.ReadLine();
        }
    }
}
