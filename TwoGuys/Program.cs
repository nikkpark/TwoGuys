using System.Xml;

namespace TwoGuys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int thatMuch))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int much = joe.GiveCash(thatMuch);
                        bob.RecieveCash(much);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int much = bob.GiveCash(thatMuch);
                        joe.RecieveCash(much);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount or blank line to exit.");
                }
            }
        }
    }
}