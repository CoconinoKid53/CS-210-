using System;

class Program
{
    static void Main(string[] args)
    {
        // create sccripture object
        Scripture scripture = new Scripture ("For the Lord hath poured out upon you the spirit of deep sleep, and hath closed your eyes: the prophets and your rulers, the seers hath he covered");
        // store the scripture 
       

        // //  called upon refrence and made new string variables
        // Reference reference = new Reference();
        // reference._book = "Isaiah";
        // reference._chapter = "29";
        // reference._starting_verse = "10";
        
        // Clear the console
        // Console.Clear();
        // // display the reference
        // Console.WriteLine($"{reference._book} {reference._chapter}:{reference._starting_verse}" );
        // // diplay the text of the scripture 
        // Console.WriteLine($"{scripture._scripture}");
        
        // // display prompt for user so they can type enter or quit to finish
        // Console.WriteLine("press enter to continue or type quit to finish");
        // // geeting the results of the user
        // string response = Console.ReadLine();

        while(true){
            scripture.display_scripture();
           string input = Console.ReadLine();
           if(input=="quit " || scripture.checkallwords())  {
            break;
           }
            scripture.hide_scripture();
        }

    }
}