using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson7 {
   class Fish {

      public int solution(int[] A, int[] B) {

         if (A.Length == 0) { return 0; }

         var stack = new Stack<KeyValuePair<int, int>>();

         for (int i = 0; i < A.Length; i++) {

            if (stack.Any() && stack.Peek().Value == 1 && B[i] == 0) {

               Console.Write($"{A[i]},{B[i]}->");
               Console.WriteLine($"{stack.Peek().Key},{stack.Peek().Value}->");

               while (stack.Any() &&
                  stack.Peek().Value == 1 &&
                  B[i] == 0 && stack.Peek().Key < A[i]) {
                  stack.Pop();
               }

               if (!stack.Any() || B[i] == stack.Peek().Value) {
                  stack.Push(
                  new KeyValuePair<int, int>(A[i], B[i]));
               }

            } else {
               stack.Push(
                  new KeyValuePair<int, int>(A[i], B[i]));
            }
         }

         return stack.Count();

      }




   }
}
