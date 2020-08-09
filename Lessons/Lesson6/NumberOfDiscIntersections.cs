using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class NumberOfDiscIntersections {
      public int solution(int[] A) {
         var length = A.Length;
         var points = new KeyValuePair<int, long>[2 * length];
         for (long i = 0; i < length; i++) {
            points[2 * i] = new KeyValuePair<int, long>((int)i, i + (long)A[i]);
            points[2 * i + 1] = new KeyValuePair<int, long>((int)i, i - (long)A[i]);
         }
         Array.Sort(points, (a, b) => (int)(a.Value - b.Value));


         var pointSet = new HashSet<int>();
         var inside = 0;
         var total = 0;

         foreach (var a in points) {
            if (pointSet.Contains(a.Key)) {
               pointSet.Remove(a.Key);
               inside--;
            } else {
               pointSet.Add(a.Key);
               total += inside;
               if (total > 10000000) { return -1; };
               inside++;
            }


         };
         return total;

      }
   }
}
