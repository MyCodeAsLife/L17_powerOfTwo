using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_powerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int baseNumber = 2;
            int powerOfNumber = 2;
            int finalNumber = baseNumber;
            int minRangeValue = 2;
            int maxRangeValue = 100;
            int targetNumber = random.Next(minRangeValue, maxRangeValue + 1);
            bool isOpen = true;

            while (isOpen)
            {
                finalNumber *= baseNumber;

                if (finalNumber <= targetNumber)
                    powerOfNumber++;
                else
                    isOpen = false;
            }

            Console.WriteLine($"Исходное число: {targetNumber}.\n{baseNumber} в степени {powerOfNumber} равно {finalNumber}.\n");
        }
    }
}
