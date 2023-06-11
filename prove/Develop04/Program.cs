using System;

class Program
{
    // entry point
    static void Main(string[] args)
    {

        // using the phone number to place an order
        ClassMenu Project_Menu = new ClassMenu(); // this is where we get teh container of the GetInput function
            //this is how to create an object
        // this is where we call the function
        Project_Menu.GetInput();
        Activity activity = new Activity();
        activity.do_animation(2);



    }
}
