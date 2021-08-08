using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee : Person 
{

    private string _Department;
    public string Department { get => _Department; set => _Department = value; }

    public Employee(string FName, string LName, string Dept) : base(FName, LName)
    {
        _Department = Dept;
    }

    public override string Print()
    {
        var res = base.Print();
        return $"{res} from {_Department} Department";
    }
}
