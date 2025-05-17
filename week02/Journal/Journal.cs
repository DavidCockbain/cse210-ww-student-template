

using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection.Metadata;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    //Entry entry1= new Entry();
    //public List<Entry> _date, _promptText, _entryText;
    public PromptGenerator promptGenerator;

    
     
    
    public Journal( string _date, string _PromptText, string _entryText)
    {
        
        foreach (Entry entry in _entries)
            {

            _entries.Add(new Entry(entry._date, entry._PromptText, entry._entryText));
            

            }

        promptGenerator = new PromptGenerator();
    }
    public void AddEntry(string _date, string _PromptText,string _entryText)
    {
        
        
        string _promptText = promptGenerator.GenerateRandomPrompt();
        Entry entry= new Entry("","","");
        entry._PromptText = _promptText;
        
        DateTime theCurrentTime = DateTime.Now;
        string DateCreated = theCurrentTime.ToShortDateString();
        entry._date = DateCreated;
        // Console.Write($"the date({DateCreated}): ");
        Console.WriteLine($"Today's Prompt: {_promptText}");
        
        //_entries.Add(entry);
        Console.Write("> ");

        _entryText = Console.ReadLine();
     //   entry._entryText = entryText;
        
        
    }

    
        public void DisplayEntries()
    {
        Entry entry= new Entry("","","");
        Console.WriteLine($"displaying entrys");
        Console.WriteLine(entry._date,entry._PromptText,entry._entryText);
        //public string 

        // foreach (string _entry in _entryText)
        // {
        //     Console.WriteLine(_entry);
        //     Console.ReadLine();
         }


        public void SaveToFile() 
        {
            Console.Write("Please enter the filename you would like to save to: ");
            string filename = Console.ReadLine();
            try 
            {
                using (StreamWriter writer = new StreamWriter(filename)) 
                {
                    foreach (Entry entry in _entries) 
                    {
                        Console.WriteLine("saving file...");
                        writer.WriteLine($"{entry._date}\n{entry._PromptText}\n{entry._entryText}");
                    }
                }
                Console.WriteLine($"Journal entries saved to {filename}");
            } 
            catch (Exception e) 
            {
                Console.WriteLine($"Error saving entries to {filename}: {e.Message}");
            }
        }


        public void LoadFromFile() 
        {
            Console.Write("Please enter the file name you would like to load from: ");

            String filename = Console.ReadLine();
            try 
            {
                using (StreamReader reader = new StreamReader(filename)) 
                {
                    while (!reader.EndOfStream) 
                    {
                        string _date = reader.ReadLine();
                        string _promptText = reader.ReadLine();
                        string _entryText = reader.ReadLine();
                        Entry entry = new Entry(_date,_promptText ,_entryText);
                        _entries.Add(entry);
                    }
                } 
            } catch (Exception e) 
            {
                    Console.WriteLine($"Error loading entries from :filename: {e.Message}");
            }
        }

    } 