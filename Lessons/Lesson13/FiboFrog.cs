using System;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson13 {
   class FiboFrog {


      public int solution(int[] A) {
         calcFibo();
         return minJumps(A);
      }

      private int[] fibos = new int[26];


      private void calcFibo() {
         fibos[0] = 1;
         fibos[1] = 1;
         for (int i = 2; i < fibos.Length; i++) {
            fibos[i] = fibos[i - 1] + fibos[i - 2];
         }
      }
      public int minJumps(int[] A) {
         var length = A.Length;
         if (length == 0) { return 1; }
         var minJumps = new int?[length + 1];


         for (int i = 0; i < length + 1; i++) {
            if (i < length && A[i] == 0) { continue; }

            minJumps[i] = null;
            for (int j = 0; j < fibos.Length; j++) {

               if (i - fibos[j] == -1) {
                  minJumps[i] = 1;
                  break;
               }
               if (i - fibos[j] < -1) {
                  break;
               }

               if (A[i - fibos[j]] == 1) {
                  if (!(minJumps[i - fibos[j]] == null)) {

                     minJumps[i] = Math.Min(minJumps[i] ?? int.MaxValue, (int)minJumps[i - fibos[j]] + 1);
                  }
               }


            }
         }


         return minJumps[length] ?? -1;
      }
   }
}