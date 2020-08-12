using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson6 {
   class NumberOfDiscIntersections {
      public class BorderPoint {
         public long point { get; set; }
         public bool isBeginning { get; set; }

      }

      public int solution(int[] A) {

         if (A.Length == 0) return 0;

         var length = A.Length;
         var points = new BorderPoint[2 * length];

         for (int i = 0; i < length; i++) {
            points[2 * i] = new BorderPoint() { isBeginning = true, point = (long)i - (long)A[i] };
            points[2 * i + 1] = new BorderPoint() { isBeginning = false, point = (long)i + (long)A[i] };

         }

         Array.Sort(points, (p1, p2) => compare(p1, p2));

         var inCircles = 0;
         var intercect = 0;

         for (int i = 0; i < 2 * length - 1; i++) {
            if (points[i].isBeginning) {
               intercect += inCircles;
               inCircles++;
            } else {
               inCircles--;
            }

            if (intercect > 10e6) { return -1; }
         }

         return intercect;

      }


      public int compare(BorderPoint first, BorderPoint second) {
         int firstComparison = first.point.CompareTo(second.point);

         if (firstComparison != 0) {
            return firstComparison;
         } else {
            return second.isBeginning.CompareTo(first.isBeginning);
         }
      }
   }
}
