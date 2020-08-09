using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class PassingCars {
      public int solution(int[] A) {
         var goingEast = new int[A.Length + 2];
         var goingWest = new int[A.Length + 2];
         var counter = 0;

         for (int i = 1; i < A.Length + 1; i++) {
            goingWest[A.Length - i + 1] = A[A.Length - i] == 1 ? goingWest[A.Length - i + 2] + 1 : goingWest[A.Length - i + 2];
         }

         for (int i = 0; i < A.Length; i++) {
            if (A[i] == 0) {
               counter += goingWest[i + 1];
            }
         }

         return counter;
      }
   }
}
