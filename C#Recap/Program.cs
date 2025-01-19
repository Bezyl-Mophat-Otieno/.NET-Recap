using System.Runtime.CompilerServices;

namespace entry
{
    
class Vehicle
{
    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model; 
    }

    public string Make { get; set; }
    public string Model { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {Make} {Model}");
    }
}

class Car : Vehicle // Car inherits from Vehicle
{
    public Car(string make, string model, int year): base(make,model)
    {
        Year = year;
    }
    public int Year { get; set; }
}

class Animal 
{
    public string name {get;set;}

    public virtual void speak () 
    {
        Console.WriteLine("Animal Speaks");
    }
}

class Cat: Animal 
{
    public override void speak () 
    {
        Console.WriteLine("A cat meows");
    }
}


class Dog: Animal 
{
    public override void speak () 
    {
        Console.WriteLine("A dog barks");
    }
}

abstract class Shape 
{
    public abstract double Area ();

}

    class Circle : Shape
    {
        public double radius{get;set;}
        public override double Area()
        {
            return radius * radius * 3.142;
        }
    }

    class Student 
    {
        private double IQvalue = 0.234;
        public string Name {get;}
        public string CurrentClass {get;set;}

        public int TotalScoredMarks {get;set;}

        
        private int _yearOfBirth;
        public int YearOfBirth {
            get { return _yearOfBirth; }
            set {
                if (value <= 2007)
                {
                    Console.WriteLine("Underage");
                }
                _yearOfBirth = value;
            }
        }

        public void PercentageScore (int possibleMarks) 
        {
            var results = (TotalScoredMarks * IQvalue) /possibleMarks * 100;
            Console.WriteLine($"This is the percentage score {results}%");
        }
        

    } 

    class Tenant 
    {
        public Tenant(string fullname, int roomnumber)
        {
            FullName = fullname;
            RequestedRoom = roomnumber;
            
        }
        public Tenant(string fullname): this(fullname, 1)
        {
            FullName = fullname;
        }

        public string FullName;

        private readonly int _maxNumberOfAvailableRooms = 30;
        private int _requestedRoom;
        public int RequestedRoom {
            get {return _requestedRoom;}
            set {
                if(value >= _maxNumberOfAvailableRooms ){
                    Console.WriteLine("We are fully booked");
                    return;
                }
                _requestedRoom = value;
            }
        }

        public void BookingInformation ()
        {
            Console.WriteLine($"Tenant name: {FullName}, Booked room: {RequestedRoom}");
        } 

    }


    class Program
{
    static void Main(string[] args)
    {
        Car myFirsCar = new Car("Audi", "C30", 2025);
        Console.WriteLine($"My car make: {myFirsCar.Make}");
        Console.WriteLine($"My car model: {myFirsCar.Model}");
        myFirsCar.DisplayInfo();

        Dog mydog = new Dog {
            name="Bosco"
            };
        mydog.speak();
        Cat mycat = new Cat {
            name="annita"
            };
        mycat.speak();
         var circle = new Circle {radius=7.0};
         Console.WriteLine($"The area of the circle: {circle.Area()}");

         var student1 = new Student{
            CurrentClass="4East",
            TotalScoredMarks=800,
            YearOfBirth=2007,
            };

            student1.PercentageScore(1000);

        Tenant tenant31 = new Tenant("John Doe", 31);
        tenant31.BookingInformation(); 
        Tenant tenant29 = new Tenant("Bezyl Mophat");
        tenant29.BookingInformation();
    }
}
}

