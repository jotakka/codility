using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson3 {
   class PermMissingElem {
      public int solution(int[] A) {
         if (A.Length == 0) return 1;

         Array.Sort(A);

         for (int i = 0; i < A.Length; i++) {
            if (A[i] != i + 1) {
               return i + 1;
            }
         }
         return A.Length + 1;
      }
   }
}

