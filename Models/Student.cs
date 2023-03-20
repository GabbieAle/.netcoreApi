namespace _netcoreApi.Models;

public class Student
{
 public string firstName {get;set;}
 public string surName {get;set;}
 public string dni {get;set;}
 public bool status {get;set;}

}

public class Subject 
{
    public string name {get;set;}
    public DateOnly time {get; set;}
    public string teacher {get; set;}
    public string limit_of_students {get;set;}
}