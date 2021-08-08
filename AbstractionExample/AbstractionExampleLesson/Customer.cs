using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer : Person
{

    private string _deliveryAddress;
    public string DeliveryAddress { get => _deliveryAddress; set => _deliveryAddress = value; }

    public Customer(string FName, string LName, string DAdress) : base(LName, FName)
    {
        _deliveryAddress = DAdress;
    }

    public override string Print()
    {
        var res = base.Print();
        return $"{res} from {_deliveryAddress}";
    }
}

