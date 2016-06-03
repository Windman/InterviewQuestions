using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public class Singletone
    {
        public int Value;

        private static Object o = new Object();

        private static Singletone s;

        private Singletone()
        {
            Value++;
        }

        public static Singletone GetSingletone
        {
            get
            {
                lock (o)
                {
                    if (s == null)
                        s = new Singletone();
                    return s;
                }
                
            }
        }
    }
}
