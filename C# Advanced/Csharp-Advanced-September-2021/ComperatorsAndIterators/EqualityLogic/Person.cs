﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => name;

        public int Age => age;

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.name);

            if(result == 0)
            {
                result = Age.CompareTo(other.age);
            }

            return result;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Person;
            if(other == null)
            {
                return false;
            }
            return Age == other.age && Name == other.name;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
