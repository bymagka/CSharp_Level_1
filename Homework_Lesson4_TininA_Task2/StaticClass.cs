using System;

namespace Homework_Lesson4_TininA_Task2
{
    public static class StaticClass
    {
        public static int CalculateArray(int[] Array)
        {
            int count = 0;
            for (int i = 1; i < Array.GetLength(0); i++)
            {
                if ((Array[i] % 3 == 0 && Array[i - 1] % 3 != 0) || (Array[i - 1] % 3 == 0 && Array[i] % 3 != 0)) count++;
            }
            return count;
        }
    }
}
