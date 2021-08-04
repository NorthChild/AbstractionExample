using System;



public class Program
{
    static void Main(string[] args)
    {

        Customer cust = new Customer("Ellie", "Good");

        cust.LastName = "Woops";

        cust.Print();

    }
}

