using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Customer
    {
    
        private string _firstName;
        private string _lastName;
    
    
    public Customer(string FName, string LName) 
    {
        FirstName = FName;
        LastName = LName;
    }

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => _lastName; set => _lastName = value; }


    public void Print() 
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }






}

