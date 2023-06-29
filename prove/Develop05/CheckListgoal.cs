using System;


class checklistgoal : goals{
    public checklistgoal () {
        goalType = "checklist";
    }
    private checklistgoal checkoffgoal() {
        Console.WriteLine ("please check off all goals completed with a [x]");
        return  new checklistgoal();

    }
}