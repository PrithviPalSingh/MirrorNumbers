using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10000; i++)
            {
                bool IsMirrorImage = false;
                var intArray = i.ToString();
                Program.IsMirrorImage(IsMirrorImage, intArray);
            }

            Console.Read();
        }

        private static void IsMirrorImage(bool isSimilar, string intArray)
        {
            var length = intArray.Length;

            if (length == 1)
            {
                Console.WriteLine($"Mirror Number is: {intArray}");
                return;
            }

            if (length == 2)
            {
                if (IsSame(intArray, 0, intArray[1]))
                {
                    Console.WriteLine($"Mirror Number is: {intArray}");
                }

                return;
            }

            var loopLength = length % 2 == 0 ? length / 2 - 1 : length / 2;

            for (int i = 0; i <= loopLength; i++)
            {
                if (!IsSame(intArray, i, intArray[length - i - 1]))
                {
                    return;
                }
            }

            Console.WriteLine($"Mirror Number is: {intArray}");

        }

        private static bool IsSame(string intArray, int i, char numToCompare)
        {
            switch (intArray[i])
            {
                case '0':
                    return numToCompare == '0' ? true : false;                    
                case '1':
                    return numToCompare == '1' ? true : false;
                case '6':
                    return numToCompare == '9' ? true : false;
                case '8':
                    return numToCompare == '8' ? true : false;
                case '9':
                    return numToCompare == '6' ? true : false;
                default:
                    return false;
            }            
        }
    }
}
