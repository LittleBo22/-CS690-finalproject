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

        //show the calendar options to the user and get their choice
        displaychoices();
        //getUserInput();
        
        Console.WriteLine("What is your choice? ");
        string choice = Console.ReadLine();
        if(choice == "1"){
            addItem();
            }
        else if(choice == "2"){
            //editItem();
            }
        else if(choice =="3"){
            deleteItem();
            }
        else if(choice == "4"){
            //showCalendar();
            }
        else{
            Console.WriteLine ("That is not a valid entry");
            }
    }    

    
     //saveCalendar();
                
    //Method for getting the userID and creating a file calendar for that user
    static void getuserID(){
        Console.WriteLine("Please enter your userID using the first two initials of first and last name + apartment number. ");
        userID = Console.ReadLine();
        filePath = $"calendar_{userID}.txt";
    }
    static void displaychoices(){
        Console.WriteLine("\nCalendar options: ");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Edit Item");
        Console.WriteLine("3. Delete Item");
        Console.WriteLine("4. View Calendar");
        Console.WriteLine("5. Exit Calendar");
    }
    /*static string getUserInput(string calchoice){
        Console.WriteLine("What is your choice? (enter number choice) ");
        return Console.ReadLine();
    }*/
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
        Console.WriteLine("Do you want to add more or save the calendar? ");
        string command = Console.ReadLine();
        if (command == "save")
            saveCalendar();
        }
        
    static void saveCalendar(){
        List<string> calitemlines = calItem.Select(item => $"{item.Date.ToShortDateString()}|{item.Title}|{item.Description}").ToList();
        File.AppendAllLines(filePath, calitemlines);
        }
    static void deleteItem(){
        //Console.WriteLine("Here is a list of your items.");
        calItem.ForEach(i => Console.WriteLine(i));
        Console.WriteLine("Enter the number of the item to be deleted. ");
        }
}