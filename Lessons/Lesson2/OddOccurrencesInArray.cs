using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson2 {
   class OddOccurrencesInArray {
      public int solution(int[] A) {
         // write your code in C# 6.0 with .NET 4.5 (Mono)


         Array.Sort(A);
         var count = 1;

         for (int i = 0; i < A.Length - 1; i++) {
            if (A[i] == A[i + 1]) {
               count++;
            } else {
               if (count % 2 == 1) return A[i];
               count = 1;
            }
         }
         return A[A.Length - 1];

      }
   }
}
