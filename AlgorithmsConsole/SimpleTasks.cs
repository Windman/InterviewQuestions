using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public static class SimpleArrayTasks
    {
        public static IEnumerable<int> CreateAscendingArrayWithYield(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<int> CreateDescendingArrayWithYield(int n)
        {
            for (int i = n; i >= 0; i--)
            {
                yield return i;
            }
        }

        public static int[] Merge(int[] data1, int[] data2)
        {
            int length = data1.Length + data2.Length;
            int[] newdata = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    if (i < data1.Length)
            //        newdata[i] = data1[i];
            //    else if (i >= data1.Length && i < length)
            //    {
            //        int offcet = data2.Length - (length - i);
            //        newdata[i] = data2[offcet];
            //    }
            //}
            int current = 0;

            for (int i = 0; i < data1.Length; i++)
            {
                newdata[current++] = data1[i];
            }

            for (int i = 0; i < data2.Length; i++)
            {
                newdata[current++] = data2[i];
            }
            return newdata;
        }

        public static void PrintArray<T>(IEnumerable<T> data)
        {
            foreach (var item in data)
            {
                Console.Write("{0} {1}", item, " ");
            }
        }
    }
}
