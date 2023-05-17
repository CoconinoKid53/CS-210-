class Prompt {
    List <string> _prompts = new List<string> () {
        "How was your day?", 
        "What is something cool you learned today?", 
        "What did you eat today?", 
        "Who did you talk to today?"
    };
    Random _rnd = new Random();

    public string randomReturnPrompt () {
        int randomNumber= _rnd.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}