using System;

public class Scripture
{
    //private string _scripture;
    //Random object Random rnd = new Random();
    Referance _referance = new Referance("2Nephi",2,27,27,0);
    public List<string> _words = new List<string>();
    private string scripture = ("Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.");


    //foreach (string _word in words)
    //    {}

    
    public Scripture()
    {
        foreach (var word in scripture.Split(" "))
        {
            _words.Add(word);
            //Console.WriteLine(word);
        }
        

        //_referance.GetDisplayText();
        
        //words.Add(new Word(""));
    }
    public void HideRandomWords(int numberToHide)
    {
        Get random index int index = rnd. Next(fruits. Count);
        //_words.Clear();

    }
    public void GetDesplayText()
    {
        Console.WriteLine ($"{_referance}{scripture}");
        
    }
}