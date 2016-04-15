using System;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static int Func(ref double[] arr)
        {
            var item = arr
                .Select((x, i) => new {Index = i, Value = x})
                .FirstOrDefault(x => x.Value > 100);
            if (item == null)
                return arr.Length;
            for (int i = item.Index; i < arr.Length; ++i)
            {
                arr[i] /= 100;
            }
            return item.Index;
        }

        static void PrintArray(double[] arr, string message)
        {
            Console.WriteLine(message);
            foreach (var val in arr)
            {
                Console.Write("{0} ", val);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr = new[] {110.0, 1.0};
            PrintArray(arr, "Input:");

            var pos = Func(ref arr);
            PrintArray(arr, "Output:");
        }
    }
}
