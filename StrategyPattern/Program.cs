using StrategyPattern;
using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start getting tickets");
        var random = new Random();
        for (int i = 0; i < 5; i++)
        {
            var ticket = new Ticket();
            ticket.SetName("Ticket " + (i + 1));
            ticket.SetPrice(50 * i);
            GeneratePromoteStrategy(random, ticket);
            LogTicket(ticket);
            GeneratePromoteStrategy(random, ticket);
            LogTicket(ticket);
             
        }
    }

    private static void LogTicket(Ticket ticket)
    {
        Console.WriteLine("Promoted price of " + 
            ticket.GetName() + " is " + ticket.GetPromotedPrice() + 
            " " + ticket.GetPromoteStrategy().GetType() 
            + "\n");
    }

    private static void GeneratePromoteStrategy(Random random, Ticket ticket)
    {
        var strategyIndex = random.Next(0, 2);
            
        switch (strategyIndex)
        {
            case 0:
                ticket.SetPromoteStrategy(new NoDiscountStrategy());
                break;
            case 1:
                ticket.SetPromoteStrategy(new QuaterDiscountStrategy());
                break;
            case 2:
                ticket.SetPromoteStrategy(new HalfDiscountStrategy());
                break;
        }
    }
}