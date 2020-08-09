using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson4 {
   class MaxCounters {
      public int[] solution(int N, int[] A) {

         var counters = new int[N];
         var max = 0;

         foreach (var a in A) {

            if (a > N) {

               SetMax(ref counters, max);

            } else {
               counters[a - 1]++;
               max = Math.Max(max, counters[a - 1]);
            }

         }
         return counters;
      }


      public void SetMax(ref int[] a, int value) {
         a[0] = value;
         var i = 1;
         for (; i <= a.Length / 2; i *= 2) {

            Array.Copy(a, 0, a, i, i);
         }
         Array.Copy(a, 0, a, i, a.Length - i);

      }
   }
}
