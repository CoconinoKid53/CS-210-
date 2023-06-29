using System;


class goals  {
    public int points;
    public string goaldescription;
    public string goalname;

    public string goalType;

    protected bool markedgoal = false;
    public void checkgoal() {
        markedgoal = true;
    }
    public void Set_publicgoal(int _points, string _goaldescription, string _goalname ) {
         points = _points;
         goaldescription = _goaldescription;
         goalname = _goalname;


    }
    public void mark_goal () {

    }

    public void  display_displaygoals() {
        Console.WriteLine ($"{points}, {goaldescription}, {goalname}");


    }

    public string savegoals_savegoals (goals goal) {    
        return ($"{points}, {goaldescription}, {goalname}");
    }

    public string loadgoals () {
        return ($"{goalname} , {goaldescription}, {points}");
    }

    public int getSum(int addend1, int addend2) {
        int sum = addend1 + addend2;
        return sum;
    }

    public int addNumbers() {
        int sum = getSum(2, 3);
        return sum;
    } 


}