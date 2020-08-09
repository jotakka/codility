using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson1 {
   class BinaryGap {
      static int solution(int N) {
         int[] i;


         var n = N;
         var counter = 0;
         var maxValue = 0;
         var length = sizeof(int) * 8;

         while ((N & 0x01) == 0 && ((n >>= 1) & 0x1) == 0 && length > 0) { length--; }

         do {

            if ((n & 0x01) == 1) {
               maxValue = Math.Max(counter, maxValue);
               counter = 0;
            } else {
               counter++;
            }
            n >>= 1;
         } while ((--length) != 0 & n > 0);

         return maxValue;
      }
   }
}
