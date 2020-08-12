using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson9 {
   class MaximumSliceProblem {


      public int solution(int[] A) {

         var sums = new long[A.Length];
         //Array.Sort(A);
         sumArray(A, sums);

         var maxDif = long.MinValue;
         var minSum = 0L;
         for (int i = 1; i < A.Length; i++) {

            minSum = Math.Min(minSum, sums[i]);

            maxDif = Math.Max(maxDif, sums[i] - minSum);

         }
         return (int)maxDif;
      }

      private static void sumArray(int[] A, long[] sums) {
         sums[0] = A[0];
         for (int i = 1; i < A.Length; i++) {
            sums[i] = sums[i - 1] + (long)A[i];
         }
      }
   }
}
