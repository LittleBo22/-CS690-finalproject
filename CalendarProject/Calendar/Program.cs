namespace CalendarProject;

using System.IO;

class Program
{
    private static string userID;
    private static string filePath;
    static void Main(string[] args)
    {
        getuserID();
        //Load the calendar with a method?

        //show the calendar options to the user and get their choice
        Console.WriteLine("Calendar options: ");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Edit Item");
        Console.WriteLine("3. Delete Item");
        Console.WriteLine("4. View Calendar");
        Console.WriteLine("5. Exit Calendar");

        Console.Write("What is your choice? ");
        string choice = Console.ReadLine();
        
        switch(choice){
            case "1":
            break;
            case "2":
            break;
            case "3":
            break;
            case "4":
            break;
            case "5":
            break;
            default:
                Console.Write("That is not a valid entry.");
                break;
        }
    //Method for getting the userID and creating a file for that user
    static void getuserID(){
        Console.WriteLine("Please enter your user name using the first two initials of first and last name + apartment number. ");
        userID = Console.ReadLine();
        filePath = $"calendar_{userID}.txt";
    }   

        /*display calendar

        Console.Write("Would you like to add, edit, delete or exit from the calendar? ");
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
