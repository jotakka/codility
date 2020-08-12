using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson5 {
   class GenomicRangeQuery {


      Dictionary<char, int> nucDict = new Dictionary<char, int>() { { 'A',1 }, { 'C',2 },
         { 'G',3 }, { 'T',4 } };




      private int[,] countNuncCalc(string S) {
         var arr = new int[S.Length, 4];
         arr[0, nucDict[S[0]] - 1]++;
         for (int i = 1; i < S.Length; i++) {
            for (int j = 0; j < 4; j++) {
               arr[i, j] = arr[i - 1, j];
            }
            arr[i, nucDict[S[i]] - 1]++;
         }

         return arr;
      }

      public int[] solution(string S, int[] P, int[] Q) {

         var len = P.Length;
         var ans = new int[Q.Length];
         var arrNuc = countNuncCalc(S);


         for (int i = 0; i < len; i++) {

            var end = Q[i];
            var start = P[i];

            if (end != start) {
               for (int j = 0; j < 4; j++) {

                  if (arrNuc[end, j] - arrNuc[start, j] > 0) {
                     ans[i] = j + 1;
                     break;
                  }
               }
            } else {

               ans[i] = nucDict[S[start]];
            }

            ans[i] = ans[i] == 0 ? 4 : ans[i];
         }


         return ans;
      }


   }
}
