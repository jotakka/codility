using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson3 {
   class TapeEquilibrium {



      public int solution(int[] A) {

         var len = A.Length;
         int[] sums = prefixSum(A, len);

         var total = sums[len - 1];
         var minDiff = int.MaxValue;
         for (int i = 0; i < len - 1; i++) {
            minDiff = Math.Min(minDiff, Math.Abs(total - 2 * sums[i]));
         }

         return minDiff;

      }

      private static int[] prefixSum(int[] A, int len) {
         var sums = new int[len];
         sums[0] = A[0];
         for (int i = 1; i < len; i++) {
            sums[i] = A[i] + sums[i - 1];
         }

         return sums;
      }
   }
}
