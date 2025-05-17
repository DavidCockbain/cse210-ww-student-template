// public class Entry
// {


//     
//     {
        
//     }
// }

using System;
using System.Net.Mime;
using System.Collections.Generic;
using System.Dynamic;


public class Entry
{
    public string _date;
    public string _PromptText;
    public string _entryText;

    // public Entry()
    // {
    // }

    public Entry(string date, string promptText, string entryText) 
    {
        _date = date;
        _PromptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        
        //public List<Entry> _date, _promptText, _entryText;

        
    }

    
}

    //         Content = content;
    // Console.WriteLine(content, dateInput, content); 



    // public void DisplayEntry()
    // {
    //     Console.WriteLine($"Date: {DateCreated}");
    //     Console.WriteLine($"Content: {Content}\n");
    //     Console.ReadLine();
    // }









    // public Entry() 
    // {
    //     _entries = new List<String>();

    //     promptGenerator = new PromptGenerator();

    // }





   
        //         public List<string[]> parseCSV(string path)
        // {
        //    // List<string[]> parsedData = new List<string[]>();
        //     try
        //     {
        //         using (StreamReader readfile = new StreamReader(path))
        //         {
        //             string line;
        //             string[] row;
        //             while ((line = readfile.ReadLine()) != null)
        //             {
        //                 row = line.Split('\t');
        //                 parsedData.Add(row);
        //             }
        //         }
        //     }
        //     catch (Exception e)
        //     {

        //     }

        //     return parsedData;
        // }

        // _entry.DisplayEntry();






        // public void SaveToFile() 
        // {
        //     Console.Write("Please enter the filename you would like to save to: ");
        //     string filename = Console.ReadLine();
        //     try {
        //         using (StreamWriter writer = new StreamWriter(filename)) 
        //         {
        //             foreach (String _entry in _entries) 
        //             {
        //                 writer.WriteLine($"{_entry._date}\n{_entry.}");
        //             }
        //         }
        //         Console.WriteLine($"Journal entries saved to {filename}");
        //     } catch (Exception e) 
        //     {
        //         Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
        //     }
        // }

        //Loads Entries from a file named by the user
        // public void LoadFromFile() 
        // {
        //     Console.Write("Please enter the file name you would like to load from: ");
        //     String filename = Console.ReadLine();
        //     filename = ($"{filename}.txt");
        //     try {
        //         using (StreamReader reader = new StreamReader(filename)) 
        //         {
        //             while (!reader.EndOfStream) 
        //             {
        //                 string dateString = reader.ReadLine();
        //                 string content = reader.ReadLine();
        //                 Entry entry = new Entry(dateString, content);
        //                 entries.Add(entry);
        //             }
        //         } 
        //     } catch (Exception e) 
        //     {
        //             Console.WriteLine($"Error loading entries from :filename: {e.Message}");
        //     }
        // }

    
