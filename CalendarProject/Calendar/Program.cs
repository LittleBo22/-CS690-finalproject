namespace CalendarProject;
using System.Collections.Generic;
using System;
using System.IO;
class Program
{
    struct calendarItem{
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString() {
            return $"{Date.ToShortDateString()}|{Title}|{Description}";
        }
    }
    private static string userID;
    private static string filePath;
    private static List<calendarItem> calItem = new List<calendarItem>();
    static void Main(string[] args)
    {
        getuserID();
        //Load the calendar with a method?
        loadCalendar();

        bool logged_on = true;
        while (logged_on){
        //show the calendar options to the user and get their choice
        Console.WriteLine("\nCalendar options: ");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Edit Item");
        Console.WriteLine("3. Delete Item");
        Console.WriteLine("4. View Calendar");
        Console.WriteLine("5. Exit Calendar");

        Console.Write("What is your choice? ");
        string choice = Console.ReadLine();
        
        switch(choice){
            case "1":
                addItem();
            break;
            case "2":
            break;
            case "3":
            break;
            case "4":
            break;
            case "5":
                logged_on = false;
                saveCalendar();
                break;
            default:
                Console.Write("That is not a valid entry.");
                break;
        }
    }
    //Method for getting the userID and creating a file calendar for that user
    static void getuserID(){
        Console.WriteLine("Please enter your userID using the first two initials of first and last name + apartment number. ");
        userID = Console.ReadLine();
        filePath = $"calendar_{userID}.txt";
    }

    static void loadCalendar(){
        if(File.Exists(filePath)){
            string[] content = File.ReadAllLines(filePath);
            foreach (string line in content){
                Console.WriteLine(line);
            }}
        else{
            Console.Write("A calendar doesn't exist for you. Add an item and one will be created for you.");
        }   
    }
        
        static void addItem(){
        Console.WriteLine("Enter the date in (yyyy/mm/dd) format. ");
        string userDate = Console.ReadLine();
        DateTime datevalue;
            if(DateTime.TryParse(userDate, out datevalue))
        Console.WriteLine("Enter a title: ");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the description. ");
        string description = Console.ReadLine();
        calItem.Add(new calendarItem {Date = datevalue , Title = title , Description = description});
        //order the list here 
        }
        
        static void saveCalendar(){
            List<string> calitemlines = calItem.Select(item => $"{item.Date.ToShortDateString()}|{item.Title}|{item.Description}").ToList();
            File.WriteAllLines(filePath, calitemlines);
        }

        /*Console.Write("Would you like to add, edit, delete or exit from the calendar? ");
        string action = Console.ReadLine();

        if(action == "add");{
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Enter a title: ");
            Console.Write("Enter a description: ");
        }    
            
            //saves changes to calendar
            //ask what the user would like to do

        else if (action == "edit");{
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Select the item: ");
            Console.Write("Enter new information: ");
        }

            //save changes to the calendar
            //ask what the user would like to do
            
        else if(action == "delete");{
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Select the item: ");
        }
            //save changes to the calendar to remove the item
            //ask the user what they would like to do
        Console.Write("Would you like to add, edit, delete or exit from the calendar? ");
        action = Console.ReadLine();*/
    }
}
