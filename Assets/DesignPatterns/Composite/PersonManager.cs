using System.Collections.Generic;
using UnityEngine;
using CompositeDesignPattern;

public class PersonManager : MonoBehaviour
{
    private List<Person> persons = new List<Person>();

    void Start()
    {
        persons.Add(new Developer("Alfred", 58));
        persons.Add(new Developer("Sabrina", 27));
        persons.Add(new Teacher("Anthony", 32, TeachingSubject.Science));
        persons.Add(new Teacher("Jeremy", 32, TeachingSubject.English));

        for (var i = 0; i < persons.Count; i++) 
        {
            persons[i].Work();
        }
    }
}
