namespace CalendarProject;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("This is the main page to log into the calendar. ");
        Console.Write("Apartment Manager please enter admin + the first two initials of first and last name. ");
        Console.Write("Residents please enter the first two initials of first and last name + apartment number. ");
        string user = Console.ReadLine();

        //display calendar

        Console.Write("Would you like to add, edit, delete or exit from the calendar? ");
        string action;

        do {
            if(action == "add");
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Enter a title: ");
            Console.Write("Enter a description: ");
            
            //saves changes to calendar
            //ask what the user would like to do

            else if (action == "edit");
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Select the item: ");
            Console.Write("Enter new information: ");

            //save changes to the calendar
            //ask what the user would like to do
            

            else if(action == "delete");
            Console.Write("Select the month: ");
            Console.Write("Select the day: ");
            Console.Write("Select the item: ");

            //save changes to the calendar to remove the item
            //ask the user what they would like to do
            Console.Write("Would you like to add, edit, delete or exit from the calendar? ");
            action = Console.ReadLine();

        } while(action != "exit");  

    }
}
