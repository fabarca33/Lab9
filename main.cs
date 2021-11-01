using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Employee");

    Employee unknown = new Employee();

    unknown.Intro();

    Employee johnsmith = new Employee("John", "Smith", "1234", 45);

    johnsmith.Intro();



  }
}