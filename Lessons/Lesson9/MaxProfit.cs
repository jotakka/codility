using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson9 {
   class MaxProfit {
      public int solution(int[] A) {
         var length = A.Length;
         if (length == 0) return 0;


         var initial = A[0];
         var minDay = int.MaxValue;
         var maxDay = int.MinValue;
         var maxDiff = int.MinValue;
         for (int i = 0; i < length; i++) {


            if (A[i] < minDay) {
               minDay = Math.Min(A[i], minDay);
               maxDay = int.MinValue;
            } else {
               maxDay = Math.Max(A[i], maxDay);
               maxDiff = Math.Max(maxDiff, maxDay - minDay);
            }

            Console.WriteLine($"{minDay}{ maxDay}");
         }


         return maxDiff;
      }

   }
}
