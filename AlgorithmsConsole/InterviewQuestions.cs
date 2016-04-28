using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsConsole
{
    internal class InterviewQuestions
    { 
        #region Q1
        public static void ExecuteQ1Code()
        {
            var first = new First();
            first.Execute();

            first = new Second();
            first.Execute();
            first.Simple();

            Second s = new Second();
            s.Simple();

            first = new Third();
            first.Execute();
        }
        internal class First{
            public virtual void Execute()
            {
                Console.WriteLine("FIRST WRITING");
            }

            public void Simple()
            {
                Console.WriteLine("Simple");
            }
        }
        internal class Second : First{
            public override void Execute()
            {
                Console.WriteLine("SECOND WRITING");
            }

            public void Simple()
            {
                Console.WriteLine("On Top of the Simple");
            }
        }
        internal class Third : Second{
            public override void Execute()
            {
                Console.WriteLine("THIRD WRITING");
            }
        }
        #endregion
        #region Q2

        public static void ExecuteQ2Code(){
            var actionQueue = new ActionQueue();
            actionQueue.Add(() =>
            {
                Console.WriteLine(1);
                actionQueue
                    .AddRange(Enumerable.Range(2, 8)
                    .Select(x => new Action(() => Console.WriteLine(x))));
            });
            actionQueue.Add(() => Console.WriteLine(10));
            actionQueue.RunAll();
        }

        internal class ActionQueue {
            private readonly Queue<Action> _queue = new Queue<Action>();
            public void Add(Action action)
            {
                _queue.Enqueue(action);
            }

            public void AddRange(IEnumerable<Action> actions)
            {
                actions.ToList().ForEach(Add);
            }

            public void RunAll()
            {
                while (_queue.Count > 0)
                {
                    var current = _queue.Dequeue();
                    current();
                }
            }
        }
        #endregion
        #region Q3
        public static void ExecuteQ3Code()
        {
            int[] a = new Int32[] { 1, 2, 3};
		    int[] b = new Int32[] { 1, 3, 5, 6 };

		    List<Int32> bag = new List<Int32>();
		    int length = a.Length + b.Length;
		    int j = 0;

		    for (int i = 0; i < a.Length; i++) {
			    if (a[i] < b[j])
				    bag.Add(a[i]);
			    else if (a[i] > b[j])
				    bag.Add(b[j]);
			    else {
				    bag.Add(a[i]);
				    bag.Add(b[j]);
				    j++;
			    }
		    }

		    for (j = j; j < b.Length; j++) {
			    bag.Add(b[j]);
		    }

		    foreach (Int32 e in bag) {
                Console.WriteLine(e);
			}    
        }
        #endregion
        #region Q4
        public static long ExecuteQ3Code(int n)
        {
            long result;

            if (n < 2)
                result = 1;
            else
            {
                result = ExecuteQ3Code(n - 1) + ExecuteQ3Code(n - 2);
            }
            return result;
        }
        #endregion
        #region Q5
        internal struct Point
        {
            private Int32 m_x, m_y;

            public Point(Int32 x, Int32 y)
            {
                m_x = x; m_y = y;
            }

            public void Change(Int32 x, Int32 y)
            {
                m_x = x; m_y = y;
            }

            public override string ToString()
            {
                return String.Format("({0}, {1})", m_x.ToString(), m_y.ToString());
            }
        }

        public static void ExecuteQ4Code()
        {
            Point p = new Point(1, 1);
            p.Change(2, 2);
            Object o = p;
            Console.WriteLine(o);
            ((Point)o).Change(3, 3);
            Console.WriteLine(o);
        }

        #endregion
        #region Q6
        delegate void P();

        public static void ExecuteQ6Code()
        {
            List<Action<int>> actions = new List<Action<int>>();
            for (int counter = 0; counter < 10; counter++)
            {
                //rewrite without <int> instead create int copy in the body of the loop
                actions.Add(
                    (int copy) => {Console.WriteLine(copy);}
                    );
            }

            // Then execute them
            foreach (Action<int> action in actions)
            {
                action(0);
            }
        }
        #endregion
        #region Q7
        public static void ExecuteQ7()
        {
            List<SomeReff> l = new List<SomeReff>();
            l.Add(new SomeReff { x = 1 });
            l.Add(new SomeReff { x = 2 });

            List<SomeReff> l2 = l;

            l2[0].x = 3;
            //What was happend with l collection elemen t

            var sr1 = l[0];
            var sr2 = l[1];

            l = null;

            Console.WriteLine("{0} {1}", sr1.x, sr2.x);
        }
        #endregion
        #region Q8
        public static void ExecuteQ8()
        {
            var list = new[] { "A", "B", "C", "D", "E", "F" };
            //var half = list.Where(x => indexOf(x) < 3).ToList(); //Don't work
            var half = list.Where((t, i) => i < 3).ToList(); // Work
        }
        #endregion
        #region Q9
        public static void ExecuteQ9()
        {
            dynamic obj = new { City = 1 };
            obj.City = "SanFrancisco";
            Console.WriteLine(obj.City);
        }
        #endregion
        #region Q10
        public static void ExecuteQ10()
        {
            dynamic din = 5m;
            din += 5;
            Print(din);
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
        #endregion
    }
}
