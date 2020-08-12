using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson7 {
   class SimpleBrackets {


      public int solution(String S) {
         if (S.Length == 0) { return 0; }

         var stack = new Stack<char>();

         foreach (var s in S) {

            if (s == ')') {
               if (stack.Peek() == ')') {
                  stack.Pop();
               } else {
                  return 0;
               }
            } else {
               stack.Push(s);
            }
         }

         return stack.Count() != 0 ? 0 : 1;

      }

   }
}
