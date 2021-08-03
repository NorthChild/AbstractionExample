using System;



class Program
{
    static void Main(string[] args)
    {

        Customer cust = new Customer("Ellie", "Good");

        //Console.WriteLine(cust.FirstName + " " + cust.LastName);

        cust.Print();

    }
}

