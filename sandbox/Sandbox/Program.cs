using System;

class Program
{
    static void Main(string[] args)
      // object
        // instance




        class Student{
            private string _name;
        class Student: Person {


            class BYUIPerson: Person{
                private string _iNumber;


                // sub class
                // child class
                class Student: BYUIPerson {
            public BYUIPerson(string name, string iNumber): base(name) {
                _iNumber = iNumber;

            }

                }
            }

            private string _iNumber;

            public Student(string name, string iNumber, string major) : base(name, iNumber) {
                _major = major;
            }
                        private string _major;
        }



        }

    class Teacher {

        private string_name;

        private string _iNumber;
        

        private string _department;
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

