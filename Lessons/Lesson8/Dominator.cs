using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace codility.Lessons.Lesson8 {

   class Dominator {
      public int solution(int[] A) {
         int value = 0;
         var dict = new Dictionary<int, int[]>();
         var length = A.Length;
         if (A.Length == 0) {
            return -1;
         }

         var size = 0;

         for (int i = 0; i < length; i++) {

            if (dict.ContainsKey(A[i])) {

               dict[A[i]][1]++;
            } else {
               dict.Add(A[i], new int[] { i, 1 });
            }

            if (size == 0) {
               value = A[i];
               size++;
            } else {
               size = value != A[i] ? size - 1 : size + 1;
            }

         }
         if (size <= 0) { return -1; }


         if (dict[value][1] > length / 2) {
            return dict[value][0];
         } else {
            return -1;
         }

      }
   }
}
