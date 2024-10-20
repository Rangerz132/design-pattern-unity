using UnityEngine;
using CompositeDesignPattern;

public enum TeachingSubject
{
    Math,
    Science,
    English,
    French,
    History
}

public class Teacher : Person
{
    private TeachingSubject teachingSubject;

    public Teacher(string personName, int age, TeachingSubject teachingSubject) : base(personName, age) // Call base constructor
    {
        this.teachingSubject = teachingSubject;
        workDelegate = Teach;
    }

    public void Teach()
    {
        Debug.Log(personName + " teach " + teachingSubject.ToString());
    }
}
