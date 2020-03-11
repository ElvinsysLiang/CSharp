using System;

namespace CP00Forms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = null;
            Print(iArray);
        }
        public static void Print(int[] iArray)
        {
            if (iArray == null)
            {
                Console.WriteLine("error");
            }
            else
            {
                for (int i = 0; i < iArray.Length; i++)
                {
                    Console.WriteLine(iArray[i]);
                }
            }
        }
    }
}
