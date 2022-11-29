using System;

public class Program
{
    public static void Main()
    {
        Console.Write("How many people are we making PB&J sandwiches for? ");

        int people = int.Parse(Console.ReadLine());

        int slices = people * 2;
        int TbspPB = people * 2;
        int TspJelly = people * 4;
        double TotalLoavesNeeded = Math.Ceiling((double)slices / (double)28);
        double TotalJarsPBNeeded = Math.Ceiling((double)TbspPB / (double)32);
        double TotalJarsJellyNeeded = Math.Ceiling((double)TspJelly / (double)48);

        Console.WriteLine();
        Console.WriteLine("You need: ");
        Console.WriteLine();
        Console.WriteLine(+slices + " slices of bread");
        Console.WriteLine(+TbspPB + " tablespoons of peanut butter");
        Console.WriteLine(+TspJelly + " teaspoons of jelly");

        Console.WriteLine();
        Console.WriteLine("Which is:");
        Console.WriteLine();
        if (TotalLoavesNeeded == 1) { Console.WriteLine(+TotalLoavesNeeded + " loaf of bread"); }
        else { Console.WriteLine(+TotalLoavesNeeded + " loaves of bread"); };
        if (TotalJarsPBNeeded == 1) { Console.WriteLine(+TotalJarsPBNeeded + " jar of peanut butter"); }
        else { Console.WriteLine(+TotalJarsPBNeeded + " jars of peanut butter"); };
        if (TotalJarsJellyNeeded == 1) { Console.WriteLine(+TotalJarsJellyNeeded + " jar of jelly"); }
        else { Console.WriteLine(+TotalJarsJellyNeeded + " jars of jelly"); }
        Console.WriteLine();
        string answer;
        Console.Write("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        answer = Console.ReadLine().ToLower();
        if (answer == "yes")
        {
            Main();
        }
        else if (answer == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}