using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class MaxProductOfThree {
      public int solution(int[] A) {
         Array.Sort(A);
         var l = A.Length;
         return Math.Max(A[0] * A[1] * A[l - 1], A[l - 3] * A[l - 2] * A[l - 1]);
      }
   }
}
