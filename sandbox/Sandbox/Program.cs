using System;

class Program
{
    static void Main(string[] args)
    {
        // object
        // instance
        var persnOne = new Person("Layne",  "Moseley");
        var personTwo = new Person("David", "HasselHoff");


        Layne.Talk();
        david.Talk();

    }
}


 // classification
 class Person {

    // behaivors

    // attributes
    // properties


    public void Breathe() {
        Console.WriteLine("Breathing");

    }
    
    public void Wlak() {
        Console.WriteLine("Walking"); 

    }

    public void Talk(){
        Console.WriteLine($"Hi! My name is {firstname}, {lastname}");

    }

    public string Fullname() {
       // return firstName + " " + LastName;
    }
}

