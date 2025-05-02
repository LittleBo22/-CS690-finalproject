namespace CalendarProject;

using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

class Program
{   
    static void Main(string[] args)
    {
        Console.Write("Enter your User ID: ");
        string userId = Console.ReadLine();
        string filePath = $"calendar_{userId}.txt";

        List<string> CalendarItems = new List <string>();
        if(File.Exists(filePath)){
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                CalendarItems.Add(line);
            }
            
            Console.WriteLine("Your calendar has been loaded.");}
        else
        {
            Console.Write("You don't have a calendar. Once you save items one will be created.");
        }

        string userInput;
        do{
        Console.WriteLine("Enter a command (add, delete, display, save) or end to quit.");
        userInput = Console.ReadLine();

        if(userInput == "add"){
            Console.WriteLine("Enter the calendar entry information.");
            Console.Write("Date (mm/dd/yyyy): ");
            string date = Console.ReadLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            string userAddEntry = $"{date}, {title}, {description}";
            CalendarItems.Add(userAddEntry);}

        else if (userInput == "display"){
            foreach (string item in CalendarItems)
                Console.WriteLine(item);}
        
        else if (userInput == "save"){
            File.WriteAllText(filePath, string.Join("\n", CalendarItems));}

        else if (userInput == "delete"){
            Console.WriteLine("Current Calendar Items:");
            for (int i = 0; i < CalendarItems.Count; i++){
                Console.WriteLine($"{i+1}. {CalendarItems[i]}");}
            Console.WriteLine("What is the number of the item to delete: ");
            if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber > 0 && itemNumber <= CalendarItems.Count){
                CalendarItems.RemoveAt(itemNumber - 1);}
            }
        else if (userInput == "edit"){
            Console.WriteLine("Current Calendar Items:");
            for (int i = 0; i < CalendarItems.Count; i++){
                Console.WriteLine($"{i+1}. {CalendarItems[i]}");}
            Console.WriteLine("Enter the number of the item to edit: ");
            string entryToEdit = Console.ReadLine();
            if (int.TryParse(entryToEdit, out int entryNumber)){
                if (entryNumber >= 1; && entryNumber <= CalendarItems.Count){
                    string originalEntry = CalendarItems[entryNumber];
                    string [] parts = originalEntry.Split(',');
                    if (parts.Length == 3){
                    Console.WriteLine ($"Your original entry is Date: {parts[0]},Title: {parts[1]}, Description: {parts[2]}");
                    
                    string newDate = Console.ReadLine();
                    if(!string.IsNullOrWhiteSpace(newDate)){
                        parts[0] = newDate;}

                    string newTitle = Console.ReadLine();
                    if(!string.IsNullOrWhiteSpace(newTitle)){
                        parts[0] = newTitle;}

                    string newDescription = Console.ReadLine();
                    if(!string.IsNullOrWhiteSpace(newDescription)){
                        parts[0] = newDescription;}
                    }}}
            }
        } while (userInput !="end");
    }
}