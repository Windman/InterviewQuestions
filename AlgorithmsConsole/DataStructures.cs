using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public struct Stuff
    {
        int Age ;
        string Name ;
        
        public Stuff(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string PrintPerson()
        {
            return Name + " " + Age;
        }
    }

    public static class DataStructures
    {
        public static void HashCode()
        {
            var p1 = new Stuff("Max", 30);
            var p2 = new Stuff("Max", 31);
            var p3 = new Stuff("Denzel1", 31);
            var p4 = new Stuff("Denzel2", 31);
            var p5 = new Stuff("Denzel3", 31); 
            
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p3.GetHashCode());

            var dic2 = new Dictionary<Stuff, Stuff>();
            dic2.Add(p1, p1);
            dic2.Add(p2, p2);
            dic2.Add(p3, p3);
            dic2.Add(p4, p4);
            dic2.Add(p5, p5);

            var val1 = dic2[p5];
            
        }

        public static void PrintPerson(Stuff p)
        {
            Console.WriteLine("{0}, hash code: {1}", p.PrintPerson(), p.GetHashCode());
        }
    }
}
