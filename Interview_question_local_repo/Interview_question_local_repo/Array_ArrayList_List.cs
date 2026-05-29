using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Array_ArrayList_List
    {
        public Array_ArrayList_List()
        {
            // Array
            int[] array = new int[3] { 1, 2, 3 };

            // ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");            // Not type-safe

            // List<T>
            List<int> genericList = new List<int> { 1, 2, 3 };

        }
    }
}
