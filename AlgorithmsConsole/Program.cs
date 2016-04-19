using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AlgorithmsConsole
{
    class SomeReff { public Int32 x;}

    class Program
    {
        public struct Point
        {
            public int x, y;
        }

        public static void Main(string[] args)
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
}
