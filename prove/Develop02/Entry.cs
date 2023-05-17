class Entry {

   public string _text;
   public string _date;
   public string _prompt;

    // Display all the entry information
    public void Display() {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Entry: {_prompt}");
        Console.WriteLine($"Entry: {_text}");
    }
}
