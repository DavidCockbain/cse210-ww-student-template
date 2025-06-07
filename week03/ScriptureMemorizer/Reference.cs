public class Referance
{
    private string _book;
    
    private int _chapter;
    private int _verse;
    private int _endVerse;

    

    public Referance(string _book, int _chapter, int _verse, int _endVerse)
    {
         _book = "2Nephp";
         _chapter = 2;
         _verse = 37;
         _endVerse = _verse;
    }
    public Referance(string _book, int _chapter, int _verse, int _endVerse, int _startVerse)
    {

    }
    public string GetDisplayText()
    {
        return $"{_book}{_chapter};{_verse}-{_endVerse}";
    }
 }