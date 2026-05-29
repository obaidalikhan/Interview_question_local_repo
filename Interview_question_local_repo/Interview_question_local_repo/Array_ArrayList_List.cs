using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Array_ArrayList_List
    {
        public static void Run()
        {
            // Array
            int[] array = new int[3] { 1, 2, 3 };

            // Display array
            Console.WriteLine("Array: " + string.Join(", ", array));

            // ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");            // Not type-safe
            Console.WriteLine("ArrayList: " + string.Join(", ", arrayList.ToArray()));
            // Example: iterate
            Console.Write("ArrayList items: ");
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // List<T>
            List<int> genericList = new List<int> { 1, 2, 3 };
            // Display List<T>
            Console.WriteLine("List<int>: " + string.Join(", ", genericList));

            Console.Write("List<int> items: ");
            foreach (var n in genericList)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
