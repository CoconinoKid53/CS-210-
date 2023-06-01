// display the scripture
// write a method for hiding random words
// 0-3 in each iteration of loop find a random word and call the hide method
// create a constructor on scripture that will call sparse scripture method
// in the main function add a lopp


class Scripture {
    // member variable
    
    List<Word> _scripture_list = new List<Word>();

    // function
    public void display_scripture () {
        
        foreach(var Word in _scripture_list) {
           Console.Write($"{Word.GetText()} ");

        }
        


        // string text = " For the Lord Hath ...";
    }
    public void hide_scripture() {
        // foreach(var word in hide_scripture) {
        //     Console.Write($"{word.hidescripture()}")
        // }

        Random rand = new Random();
        for(int i = 0; i < 3; i ++) {

            int randNum = rand.Next(_scripture_list.Count);

            _scripture_list[randNum].Hide();
        }


    }
    public Scripture(string _scripture) {
        // create a holder and seperating words from each other
        string[] holder = _scripture.Split(" ");

        // container for all of the words (Word class)
        

        // create all the words and put them inside of the container of words
        foreach (string text in holder) {
            Word word = new Word (text);
            _scripture_list.Add(word);

        }
       
    }
    public bool checkallwords() {
        foreach(Word word in _scripture_list ) {
            if(!word.gethidden()) {
                return false;


            }
        }
        return true;
    }


}