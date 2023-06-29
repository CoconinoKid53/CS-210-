using System;

class menu {

    public void _menu () {

        List <goals> listofgoals = new List<goals>();

        while (true) {
            Console.WriteLine ("Please choose a goal?");
            Console.WriteLine ("please set points earned after completeing goal?");
            Console.WriteLine("please choose from these goals 1.create goal, 2.List goal, 3.save goals");
            Console.WriteLine("please choose from these two options 4.Load goal, 5. Record event, 6. quit");
            
            string input = Console.ReadLine ();

            if (input  == "1") {

                Console.WriteLine("which goal would you like to choose 1.simple goal, 2.Eternal goal, 3.check list goal");
                string input2 = Console.ReadLine ();

                if (input2 == "1" ) {
                    Console.WriteLine ("please enter the amount of points this goal is worth");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine ("please enter the goal description");
                    string goaldescription = Console.ReadLine();
                    Console.WriteLine("please enter the goal name");
                    string goalname = Console.ReadLine();
                    simplegoal goal = new simplegoal();
                    goal.Set_publicgoal(points, goaldescription, goalname);

                    listofgoals.Add(goal);
                }
                if (input2 == "2") {
                    Console.WriteLine ("please enter the amount of points this goal is worth");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine ("please enter the goal description");
                    string goaldescription = Console.ReadLine();
                    Console.WriteLine("please enter the goal name");
                    string goalname = Console.ReadLine();
                    Eternalgoals goal = new Eternalgoals();
                    goal.Set_publicgoal(points, goaldescription, goalname);
                     listofgoals.Add(goal);
                }
                if (input2 == "3") {
                    Console.WriteLine ("please enter the amount of points this goal is worth");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine ("please enter the goal description");
                    string goaldescription = Console.ReadLine();
                    Console.WriteLine("please enter the goal name");
                    string goalname = Console.ReadLine();
                    checklistgoal goal = new checklistgoal();
                    goal.Set_publicgoal(points, goaldescription, goalname);
                     listofgoals.Add(goal);
                }

            }
            if (input == "2") {
                foreach (goals goal in listofgoals) {
                    goal.display_displaygoals ();
                }
            }
            if (input == "3") {
                Console.Write("Please enter filename--> ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (goals goal in listofgoals) {
                        outputFile.WriteLine(($"{goal.points},{goal.goaldescription},{goal.goalname},{goal.goalType}"));

                    }                 
                }
            }
            if (input == "4") {
                Console.Write("Please enter filename--> ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                
                foreach (string line in lines) {
                    string[] parts = line.Split(",");

                    int points = int.Parse(parts[0]);
                    string goalDescription = parts[1];
                    string goalName = parts[2];
                    string goalType = parts [3];

                

                    if (goalType == "simple") {
                        var goal = new simplegoal();
                        goal.Set_publicgoal(points,goalDescription,goalName);
                        listofgoals.Add(goal);

                    } else if (goalType == "Eternal") {
                        var goal = new Eternalgoals();
                        goal.Set_publicgoal(points,goalDescription,goalName);
                        listofgoals.Add(goal);
                    } else if (goalType == "checklist") {
                        var requiredCount = int.Parse(parts[3]);
                        var completedCount = int.Parse(parts[4]);
                        var goal = new checklistgoal();
                        goal.Set_publicgoal(points,goalDescription,goalName);
                        listofgoals.Add(goal);
                    }

                    
                }
            }
            if (input == "5") {
                int choice = int.Parse(Console.ReadLine());
                listofgoals[choice].checkgoal();
                Console.WriteLine("you checked off this goal");

                // add points
                // make sure that you cant get anymore points when completed
                // you can create a display function on your goals.cs class and override it in the simple, checklist, and eternal classes 
                // so that you can check to see if the goal is completed and put an X down.
            }
        }
    }
}