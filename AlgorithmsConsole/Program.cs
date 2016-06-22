using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace AlgorithmsConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            SimpleTreeTasks t = new SimpleTreeTasks();
            var tree = t.CreateTree();
            //int max = t.FindMaxRecursionSolution(tree);

            int max = t.FindMaxWithoutRecursion(tree);
            //InterviewQuestions.ExecuteQ1Code();

            //Singletone s = Singletone.GetSingletone;
            //Singletone s1 = Singletone.GetSingletone;
            //Singletone s2 = Singletone.GetSingletone;

            //Exceptions();
            //DataStructures.HashCode();
            
            //var fib = GetFibonaci();
            //Console.WriteLine(fib(3));
            //Console.WriteLine(fib(5));
            //Console.WriteLine(fib(5));
            
            
            //InterviewQuestions.ExecuteQ1Code();
            //Console.ReadLine();
            //Dictionary<string, int> d = new Dictionary<string, int>();
            //d.Add("Key1", 1);

            //GetHashCodeExpiriments();
            //Multithreading();
            //LinqIssues();
        }

        public struct Point
        {
            public int x, y;
        }

        private static void Exceptions()
        {
            try
            {
                try
                {
                    throw new Exception("1");
                }
                catch (Exception ex)
                {
                    throw new Exception("2", ex);
                }
                finally
                {
                    throw new Exception("3");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

        }

        unsafe public static void Go()
        {
            // Выделение места под объекты, которые немедленно превращаются в мусор
            for (Int32 x = 0; x < 10000; x++) new Object();
            IntPtr originalMemoryAddress;
            Byte[] bytes = new Byte[1000]; // Располагаем этот массив
            // после мусорных объектов
            // Получаем адрес в памяти массива Byte[]
            fixed (Byte* pbytes = bytes) { originalMemoryAddress = (IntPtr)pbytes; }
            // Принудительная уборка мусора
            // Мусор исчезает, позволяя сжать массив Byte[]
            GC.Collect();
            // Повторное получение адреса массива Byte[] в памяти
            // и сравнение двух адресов
            fixed (Byte* pbytes = bytes)
            {
                Console.WriteLine("The Byte[] did{0} move during the GC",
                (originalMemoryAddress == (IntPtr)pbytes) ? " not" : null);
            }
        }

        public static Func<int, int> GetFibonaci()
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int val;

            Func<int, int> fx = (n) => 
            {
                if (n <= 1)
                {
                    return n;
                }

                if (!d.TryGetValue(n, out val))
                {
                    d[n] = val = (n - 1) + (n - 2);
                }
                
                return val;
            };

            return fx;           
        }

        public static void GetHashCodeExpiriments()
        {
            var p1 = new Person { name = "Xenon", age = 100 };
            var p2 = new Person { name = "Xenon", age = 100 };
            Console.WriteLine("{0} {1}", p1.GetHashCode(), p2.GetHashCode());

            var k1 = new KeyValuePair<int, int>(10, 29);
            var k2 = new KeyValuePair<int, int>(10, 31);
            Console.WriteLine("k1 - {0}, k2 - {1}", k1.GetHashCode(), k2.GetHashCode());

            var v1 = new KeyValuePair<int, string>(10, "abc");
            var v2 = new KeyValuePair<int, string>(10, "def");
            Console.WriteLine("v1 - {0}, v2 - {1}", v1.GetHashCode(), v2.GetHashCode());
        }

        public static void Multithreading()
        {
            var p = new Person { name = "Xenon", age = 100 };
            Console.WriteLine("{0} {1}", p.age, p.GetHashCode());
            Thread t1 = new Thread(() => { p.age = 11; Console.WriteLine("{0} {1}", p.age, p.GetHashCode()); });
            Thread t2 = new Thread(() => { p.age = 12; Console.WriteLine("{0} {1}",p.age, p.GetHashCode());});
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        public static void LinqIssues()
        {
            //Linq under the hood
            List<Person> ps = new List<Person>();
            var p = new Person { name = "Xenon", age = 100 };
            var type = p.GetType();
            ps.Add(p);

            ps.Add(new Person { name = "Max", age = 33 });
            ps.Add(new Person { name = "Misha", age = 3 });
            ps.Add(new Person { name = "Marina", age = 55 });
            ps.Add(new Person { name = "Andy", age = 1 });
            ps.Add(new Person { name = "Lena", age = 30 });

            var r = ps.Where(x => x.age > 30).ToArray();
            //Find(x => x.age == 30);
            //var sorted = ps.OrderBy(x => x.name).ThenBy(x => x.age).ToList();

            //sorted.ForEach(x => Console.WriteLine(x));
        }

        public static void Temp0()
        {
            Point[] pts = new Point[100];
            for (int i = 0; i < pts.Length; i++)
            {
                pts[i] = new Point();
                pts[i].x = i;
                pts[i].y = i + 1;
            }

            //var res1 = pts.Where(p => p.x == 100).First();
            var res2 = pts.Where(p => p.x == 100).Count();
        }

        public static void Temp()
        {
            var val = Convert.ToInt32("1d");
            //string date = "0000-00-00 00:00:00";
            //DateTime.Parse(date);

            //Console.WriteLine(((DateTime)date).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            string a = "{\"name\":\"soham \\\"the\\\" dasgupta\"}";

            //string a = @"[{""name"":""soham""}]";
            Console.WriteLine("Before:" + a);

            //Person[] person = new Person[]
            //{
            //    new Person() { name = "Soham" },
            //    new Person() { name = "Max" }
            //};

            //a = JsonConvert.SerializeObject(person);

            //a = HttpUtility.JavaScriptStringEncode(a, true);

            Console.WriteLine("After:" + a);
            var person = JsonConvert.DeserializeObject<Person>(a);


            //InterviewQuestions.ExecuteQ1Code();
            //InterviewQuestions.ExecuteQ2Code();
            //InterviewQuestions.ExecuteQ3Code();
            //Console.WriteLine(InterviewQuestions.ExecuteQ3Code(5));
            //InterviewQuestions.ExecuteQ4Code();
            //InterviewQuestions.ExecuteQ6Code();

            //Console.WriteLine(Power(power: 3, baseNumber: 4));
            //Console.WriteLine(Power(baseNumber: 4, power: 3));
        }

        public static double Power(int baseNumber, int power)
        {
            return Math.Pow(baseNumber, power);
        }
            
    }

    public class SortingProblem
    {
        /*
         Вы собираетесь совершить долгое путешествие через множество населенных пунктов. 
         * Чтобы не запутаться, вы сделали карточки вашего путешествия. 
         * Каждая карточка содержит в себе пункт отправления и пункт назначения.
         * Гарантируется, что если упорядочить эти карточки так, чтобы для каждой карточки в упорядоченном списке пункт 
         * назначения на ней совпадал с пунктом отправления в следующей карточке в списке,
         * получится один список карточек без циклов и пропусков.
         * Например, у нас есть карточки
         * Мельбурн → Кельн
         * Москва → Париж
         * Кельн → Москва
         * Если упорядочить их в соответствии с требованиями выше, то получится следующий список:
         * Мельбурн → Кельн, Кельн → Москва, Москва → Париж
         * Требуется:
         * Написать функцию, которая принимает набор неупорядоченных карточек и возвращает набор упорядоченных карточек 
         * в соответствии с требованиями выше, 
         * то есть в возвращаемом из функции списке карточек для каждой карточки пункт назначения на ней должен совпадать 
         * с пунктом отправления на следующей карточке.
         * Дать оценку сложности получившегося алгоритма сортировки
         * Написать тесты 
         * Оценивается правильность работы, производительность и читабельность кода*/

        //Какая структура лучше всего решает такую задачу?
        internal class Card: IComparable
        {
            public string Start;
            public string End;
            
            public Card next = null;

            public void Add(Card c)
            {
                Card n = this;
                while (n.next != null)
                    n = n.next;
                n.next = c;
            }

            public override string ToString()
            {
                return string.Format("{0} -> {1}" ,Start, End);
            }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Card that = obj as Card;

                if (this.Start == that.End)
                    return 1;
                else if (this.End == that.Start)
                    return -1;
                else return 0;
            }
        }
                
        internal static void Execute()
        {
            var list = new List<Card>();
            //Не работает сортировка если НьюЙорк -> Дубровник стоят первыми в списке
            list.Add(new Card { Start = "НьюЙорк", End = "Дубровник" });
            list.Add(new Card { Start = "Мельбурн", End = "Кельн" });
            list.Add(new Card { Start = "Москва", End = "Париж" });
            list.Add(new Card { Start = "Кельн", End = "Москва" });
            list.Add(new Card { Start = "Хельсинки", End = "НьюЙорк" });
            list.Add(new Card { Start = "Париж", End = "Хельсинки" });

            list.Sort();
        }
    }

    class SomeReff
    {
        public Int32 x;

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
