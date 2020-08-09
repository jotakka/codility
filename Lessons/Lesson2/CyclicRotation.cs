using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson2 {
   class CyclicRotation {
      public int[] solution(int[] A, int K) {

         var length = A.Length;
         if (length == 0 || K % length == 0) { return A; }

         var kMod = K % length;
         var toReturn = new int[length];

         Array.Copy(A, 0, toReturn, kMod, length - kMod);
         Array.Copy(A, length - kMod, toReturn, 0, kMod);
         return toReturn;

      }
   }
}
