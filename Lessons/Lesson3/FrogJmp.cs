using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson3 {
   class FrogJmp {
      public int solution(int X, int Y, int D) {

         var distance = Y - X;

         var jumps = (int)Math.Ceiling(distance / (1.0 * D));

         return jumps;
         // write your code in Java SE 8
      }
   }
}
