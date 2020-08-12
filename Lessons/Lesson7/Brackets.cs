using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codility.Lessons.Lesson7 {
   class Brackets {


      Dictionary<char, char> equivalent = new Dictionary<char, char>() {
         {'}','{'},{']','['},{')','('}
      };

      public int solution(String S) {
         var stack = new Stack<char>();

         if (string.IsNullOrEmpty(S)) return 1;
         foreach (var s in S) {

            if (stack.Any() && equivalent.ContainsKey(s) && stack.Peek() == equivalent[s]) {
               stack.Pop();
            } else {
               if (equivalent.ContainsKey(s)) { return -1; }
               stack.Push(s);
            }
         }



         return stack.Any() ? -1 : 1;

      }




   }
}
