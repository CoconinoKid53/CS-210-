class Word {

    private string _Letters;
    private bool _isHidden = false;

    public Word ( string Letters) {
        _Letters = Letters;
    }
    public void Hide() {
        _isHidden = true;

    }
    

    public void Unhide(){
        _isHidden = false;
    }
    public string GetText() {

        if (_isHidden) {

            string underscores ="";
            int numLetters = _Letters.Length;
            for (int i = 0; i < numLetters; i++) {
                underscores += "_";


            }
            return underscores;

        } else {
            return _Letters;
        }

    }
    public bool gethidden() {
        return _isHidden;
    }
}