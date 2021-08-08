using System;



public class Program
{
    static void Main(string[] args)
    {

        Person pers = new Person("nick", "person");
        Console.WriteLine(pers.Print());
       
        Customer cust = new Customer("Ellie", "Good", "Somewhere");
        Console.WriteLine(cust.Print()); 

        Employee n83 = new Employee("Lola", "Belly", "Sneakers");
        Console.WriteLine(n83.Print());



        Person person;

        Random rand = new Random();
        int myRandomInt = rand.Next(0, 2);

        if (myRandomInt == 0)
        {
            person = new Customer("jenny", "Storm", "Somewhere else");
            Console.WriteLine(person.Print());
        }
        else if (myRandomInt == 1) 
        {
            person = new Employee("jenny", "Storm", "Executions");
            Console.WriteLine(person.Print());
        }

        
    }
}

