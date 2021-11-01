using System;
class Employee {

 
  private int Age;
  private double Yearlysalary;

  public string firstname {get; set;}
  public string lastname {get; set;}
  public string id {get; set;}
  public int age {
    get{return Age;}
    set{
      if(value >= 0)
      Age = value;
      
      else{
        Age = 0;
      }
    }
  }
  public string address {get; set;}
  public string phonenumber {get; set;}
  public string title {get; set;}
  public double yearlysalary {
    get{return Yearlysalary;} 
    set{
      if(value >= 0)
      Yearlysalary = value;
      
      else{
        Yearlysalary = 0;
    }
    }
  }
  public string employmentstatus {get; set;}

  public Employee(){
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";
  }

  public Employee(string employeefirstname, string employeelastname, string employeeid, int employeeage){

    firstname = employeefirstname;
    lastname = employeelastname;
    id = employeeid;
    age = employeeage;
    employmentstatus = "active";

  }

  public void Intro()
  {
    Console.WriteLine("My name is " +firstname +" " +lastname);
    Console.WriteLine("My id is " +id);
    Console.WriteLine("My age is " +age);
    Console.WriteLine("My employment status is " +employmentstatus);
    

  }

}