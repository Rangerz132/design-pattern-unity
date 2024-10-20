using System;
using UnityEngine;
namespace CompositeDesignPattern
{
    public abstract class Person
    {
        protected string personName;
        protected int age;
        protected Action workDelegate; // Use Action instead of override Work method

        public Person(string personName, int age)
        {
            this.personName = personName;
            this.age = age;
        }

        public void Drink() { }

        public void Eat() { }

        public void Walk() { }

        public void Sleep() { }

        public void Work()
        {
            if (workDelegate != null)
            {
                workDelegate();
            }
        }
    }
}

