using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson15 {
   class AbsDistinct{
      public int solution(int[] A) {
         var set = new HashSet<long>();

         Array.ForEach(A, (a) => {
            set.Add(Math.Abs(((long)a)));
         });

         return set.Count();
      }
   }
}
