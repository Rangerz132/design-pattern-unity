using CompositeDesignPattern;
using UnityEngine;

public class Developer : Person
{
    public Developer(string personName, int age) : base(personName, age) // Call base constructor
    {
        workDelegate = Code;
    }

    public void Code() {

        Debug.Log(personName + " is coding...");
    }
}
