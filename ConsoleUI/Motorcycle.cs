using System;
namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public Motorcycle()
    {
    }
    public bool HasSideCart {get; set;}
    public override void DriveAbstract()
    {
       Console.WriteLine("This motorcycle is in drive");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine($" This{GetType().Name} is a  {GetType().BaseType.Name} is virtually in drive.");
    }
}