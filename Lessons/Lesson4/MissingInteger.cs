using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson4 {
   class MissingInteger {
      public int solution(int[] A) {

         Array.Sort(A);
         if (A[0] > 1) return 1;
         var contain1 = false;
         for (int i = 0; i < A.Length - 1; i++) {
            if (A[i] <= 0) { continue; }
            if (A[i] == 1) { contain1 = true; }
            if (A[i] > 1 && contain1 == false) {
               return 1;
            }
            var diff = A[i + 1] - A[i];
            if (diff > 1) {
               return A[i] + 1;
            }
         }
         if (A[A.Length - 1] > 1 && contain1 == false) { return 1; }
         return A[A.Length - 1] > 0 ? A[A.Length - 1] + 1 : 1;

      }
   }
}
