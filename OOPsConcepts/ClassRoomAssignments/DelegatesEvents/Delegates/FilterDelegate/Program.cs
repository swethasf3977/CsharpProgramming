using System;
using System.Collections.Generic;
namespace FilterDelegate;

public delegate bool Filter(Person p);
class Program 
{
    public static void Main(string[] args)
    {
        Person person1 = new Person(){Name = "john",Age = 41};
        Person person2 = new Person(){Name = "nivi",Age = 12};
        Person person3 = new Person(){Name = "Mateo",Age =3};
        Person person4 = new Person(){Name = "Malar",Age =31};
        Person person5 = new Person(){Name = "vasanth",Age =51};

        List<Person> people = new List<Person>(){person1,person2,person3,person4,person5};
        //invoke display people using delegate
            DisplayPeople("Children",people, IsChild);
            DisplayPeople("Adult",people, IsAdult);
            DisplayPeople("Senior",people, IsSenior);
            DisplayPeople("voter",people, IsVoter);
         
    }
    static void DisplayPeople(string title,List<Person> people,Filter filter)
    {
        System.Console.WriteLine("People in "+title+ " list are");
        foreach(Person p in people)
        {
            if (filter (p))
            {
                System.Console.WriteLine("{0} ,is {1} year old ",p.Name,p.Age);
            }

        }    

    }

    static bool IsChild(Person p)
    {
        return p.Age <15;
    }
    static bool IsVoter(Person p)
    {
        return p.Age >=18;
    }
    static bool IsAdult(Person p)
    {
        if(p.Age>=18 && p.Age<50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool IsSenior(Person p)
    {
        return p.Age >=50;
    }
    
}
    
        
    
