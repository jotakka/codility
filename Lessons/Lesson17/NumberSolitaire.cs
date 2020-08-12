using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson17 {
   class NumberSolitaire {

      public int solution(int[] A) {

         return MaxPointRecursive(A, 0);

      }


      public int MaxPointBottonUp(int[] A) {

         var length = A.Length;
         var maxSums = new int[length];
         maxSums[0] = A[0];

         for (int i = 1; i < length; i++) {

            maxSums[i] = int.MinValue;
            for (int dice = 6; dice > 0; dice--) {

               if (i - dice >= 0) {
                  maxSums[i] = Math.Max(maxSums[i], A[i] + maxSums[i-dice] );
               }
            }
         }

         return maxSums[A.Length - 1];
      }


      private Hashtable visited = new Hashtable();
      public int MaxPointRecursive(int[] A, int idx) {
         if (idx == A.Length - 1) { return A[idx]; }

         if (visited.ContainsKey(idx)) { return (int)visited[idx]; }

         var resultsArray = new int[6];
         for (int i = 0; i < 6; i++) {


            if (idx + i + 1 >= A.Length) {
               resultsArray[i] = int.MinValue;

            } else {

               resultsArray[i] = A[idx] + MaxPointRecursive(A, idx + i + 1);
            }


         }


         Array.Sort(resultsArray);
         visited.Add(idx, resultsArray[5]);
         return resultsArray[5];
      }

   }
}
