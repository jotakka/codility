using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class CountDiv {
      public int solution(int A, int B, int K) {

         return B / K - A / K + (A % K == 0 ? 1 : 0);

      }
   }
}
