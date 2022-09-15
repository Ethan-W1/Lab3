// See https://aka.ms/new-console-template for more information
using Lab3;
using System;

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
        Console.WriteLine("2. View All People");
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
        switch (option)
        {
            case 1:
                people.Add(new Person());
                break;
            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;
            case 3:
                Console.WriteLine("Type the number of the person you would like to remove");
                int personToRemove = Int32.Parse(Console.ReadLine());
                people.Remove(people[personToRemove]);
                break;
            case 4:
                Person rand = people[random.Next(people.Count())];
                Console.WriteLine(rand.LastName);
                break;
            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;
            case 6:
                Person ran = people[random.Next(people.Count())];
                Console.WriteLine(ran.Phone);
                break;
            case 0:
                Console.WriteLine("See ya!");
                break;
            default:
                Console.WriteLine("Invalid option. Can you read?");
                break;
        }
    }
}