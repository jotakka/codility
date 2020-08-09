using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson4 {
   class PermCheck {
      public int solution(int[] A) {
         Array.Sort(A);

         for (int i = 0; i < A.Length; i++) {
            if (A[i] != i + 1) {
               return 0;
            }
         }
         return 1;
      }
   }
}
