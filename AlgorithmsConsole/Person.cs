﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsole
{
    public class Person
    {
        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        public int age { get; set; }

        public override string ToString()
        {
            return name + " " + age;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
