using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class Distinct {
      public int solution(int[] A) {
         var distincts = A.Distinct().Count() ;
         return distincts;
      }
   }
}
