using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.Loader;
class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string emailAddress { get; set; }
    public Address Address { get; set; }

    void PurchaseParkingPass()
    {
        // Park yeri satın alma işlemi
    }
}
class Address
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public int postalcode { get; set; }
    public string country { get; set; }

    public bool valıdate()
    {
        return true;
    }
    public string outputAsLabel()
    {
        return $"{street}, {city}, {state}, {postalcode}, {country}";
    } 

}
class Student
{
    public int StudentNumber { get; set; }
    public int AvaregeMark {  get; set; }
    public bool IsEligibleToEnroll(string course)
    {
        return false;
    }
    public List<string> GetSeminarsTaken()
    { 
       return new List<string>(); 
    }
}
class Profesor
{
    public double Salary { get; set; }
    public string StaffNumber { get; set; }
    public int YearsOfService { get; set; }
    public int NumberOfClasses { get; set; }
    public List<Student> SupervisedStudents { get; set; } = new List<Student>();
    public void SuperviseStudent(Student student) 
    {
        SupervisedStudents.Add(student); 
    }

}