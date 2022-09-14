using Lab3;
using System.ComponentModel.DataAnnotations;

public class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        var option = 0;
        do
        {
            DisplayMenu();
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\nHit Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("------ Menu ------");
        Console.WriteLine("1. Create a new Person");
        Console.WriteLine("2. View all people");
        Console.WriteLine("3. Remove a Person");
        Console.WriteLine("4. Create and View Random Last Name");
        Console.WriteLine("5. Create and View Random SSN");
        Console.WriteLine("6. Create and View Random Phone Number");
        Console.WriteLine("0. Exit");
        Console.WriteLine("------------------");
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();
        switch(option)
        {
            case 1:
                people.Add(new Person());
                break;
            case 2:
                foreach(Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;
            case 3:
                foreach(Person p in people)
                {
                    Console.WriteLine(p);
                    Console.Write("Choose one to delete: ");
                    string choice = Console.ReadLine();
                    people.RemoveAt(choice);
                }
            case 4:
                Person randomLast = people[random.Next(people.Count())];
                Console.WriteLine(randomLast.LastName);
                break;
            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;
            case 6:
                Person randomPhone = people[random.Next(people.Count())];
                Console.Write("Choose your separator: ")
                string sep = Console.ReadLine();
                Console.WriteLine(sep.Number;
                break;
            case 0:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("You entered an invalid option!");
                break;
        }
    }
}