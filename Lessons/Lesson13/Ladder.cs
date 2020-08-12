using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson13 {
   class Ladder {
      private int[] powers2 = new int[30];
      private int[] stepsCounter;
      public int[] solution(int[] A, int[] B) {
         calcPowers2();
         stepsCounter = new int[A.Max()];
         stepsCounter[0] = 1;


         if (A.Max() > 1) {
            stepsCounter[1] = 2;
            stepsCount(stepsCounter.Length, powers2.Max());

         }

         var toReturn = new int[A.Length];
         for (int i = 0; i < A.Length; i++) {
            toReturn[i] = stepsCounter[A[i] - 1] %
           powers2[B[i] - 1];
         }

         return toReturn;
      }


      private void stepsCount(int length, int p) {
         for (int i = 2; i < length; i++) {
            stepsCounter[i] = (stepsCounter[i - 1] + stepsCounter[i - 2]) % p;
         }
      }

      private void calcPowers2() {
         powers2[0] = 2;

         for (int i = 1; i < powers2.Length; i++) {
            powers2[i] = 2 * powers2[i - 1];
         }
      }
   }
}
