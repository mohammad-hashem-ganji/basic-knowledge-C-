

using OOP;
using TodoList;

//Console.WriteLine($"1+ 2 is {StaticCalculator.Add(1, 2)}");
//Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine("Number of sides is " + Rectangle.NumberOfSides);// like static methodes
//var rectangle1 = new Rectangle(5,10);
//var rectangle2 = new Rectangle(50,100);
//Console.WriteLine(
//"Count of Rectangle objects is " + Rectangle.CountOfInstances);
//Console.WriteLine(StaticCalculator.Add(2, 3)); 
//Console.WriteLine(StaticCalculator.Add(2, 4)); 
//StaticCalculator.Add(2, 5);
//-----------------------------------------------------------------------------------
var medicalAppointment = new MedicalAppointment(
    "John smith" ,new DateTime(2023, 4, 3));
medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

/* Issues caused by procedural programming 
-spaghetti code
-No way to control who can access methods
-No separation by levels of abstraction
-Changes in requirements are hard to implement
-logic is not easily configurable*/
/*
 * OOP is a coding paradigm in which objects containing data and methods play a central role.
 * We define what data and methods objects of some type will contain by defining classes.
 * We can gave many objects (instances) of the same class.
 * code is modular, which makes it easier to maintain, reuse, and modify.
 * cod is more flexible, and we can adjust its behavior to changing needs easily.
 * dode is easier to understand.
 * It's easy to control how some methods and data can be accessed, Which makes the code less error-prone.
 * Encapsulation.
 * polymorphism 
 * Abstracion
 * inheritance
 */
Console.ReadKey();
class medicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on" + medicalAppointment.GetDate());
    }
}




class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;
    // overloading constructor.
    public MedicalAppointment(string patientName, DateTime date) :
        this(patientName, 7) // this keyword refers to another constructor from this class.
        // the compiler knows we mean public MedicalAppointment(string patientName, int daysFromNow) ,
        //because this is the one with the parameters matching the values I passed here.
        // so when this constructor is called , it first executes the code from this =>
        //public MedicalAppointment(string patientName, int daysFromNow) (constructor)
        // then the code from this constructor would be called. it avoid code duplication.
    {
        // داخل این کد تکرار کد وجود دارد. 
        //_patientName = patientName;
        //_date = date;
    }
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }
    public DateTime GetDate() => _date;
    // method overloading
    // I practiced mothod overloadin . then changed the name of the methods.
    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new medicalAppointmentPrinter();
        printer.Print(this); // when this method is called on this instance, I want to pass this instance
                             // medicalAppointment.Reschedule(new DateTime(2023, 4, 4)); 
                             // to be passed to the print method .
                             // with (this keyword) I can refer to the current instance from within it's class.
                             // (this keyword) refers to the current instance of the medical appointment class.
                             // so when this line => medicalAppointment.Reschedule(new DateTime(2023, 4, 4));
                             // being executed, this methos (Reschedule) is called and the current instance is 
                             // (this =>  medicalAppointment"it is an instance") the same instance will passed to the 
                             // print method when we reach (printer.Print(this);) line
    }
    //public void OverwriteMonthAndDay(int month, int day)
    //{
    //    _date = new DateTime(_date.Year, month, day);
    //}

    //public void MoveByMonthsAdnDays(int monthsToAdd, int daysToAdd)
    //{
    //    _date = new DateTime(
    //        _date.Year,
    //        _date.Month + monthsToAdd,
    //        _date.Day + daysToAdd);
    //}
}



































