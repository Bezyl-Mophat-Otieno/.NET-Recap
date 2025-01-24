namespace code
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
        public Car(string make, string model, int year) : base(make, model)
        {
            Year = year;
        }
        public int Year { get; set; }
    }

    class Animal
    {
        public string name { get; set; }

        public virtual void speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }

    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("A cat meows");
        }
    }


    class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("A dog barks");
        }
    }

    abstract class Shape
    {
        public abstract double Area();

    }

    class Circle : Shape
    {
        public double radius { get; set; }
        public override double Area()
        {
            return radius * radius * 3.142;
        }
    }

    class Student
    {
        private double IQvalue = 0.234;
        public string Name { get; }
        public string CurrentClass { get; set; }

        public int TotalScoredMarks { get; set; }


        private int _yearOfBirth;
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set
            {
                if (value <= 2007)
                {
                    Console.WriteLine("Underage");
                }
                _yearOfBirth = value;
            }
        }

        public void PercentageScore(int possibleMarks)
        {
            var results = (TotalScoredMarks * IQvalue) / possibleMarks * 100;
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
        public Tenant(string fullname) : this(fullname, 1)
        {
            FullName = fullname;
        }

        public string FullName;

        private readonly int _maxNumberOfAvailableRooms = 30;
        private int _requestedRoom;
        public int RequestedRoom
        {
            get { return _requestedRoom; }
            set
            {
                if (value >= _maxNumberOfAvailableRooms)
                {
                    Console.WriteLine("We are fully booked");
                    return;
                }
                _requestedRoom = value;
            }
        }

        public void BookingInformation()
        {
            Console.WriteLine($"Tenant name: {FullName}, Booked room: {RequestedRoom}");
        }

    }

    static class MathUtilities
    {
        public const double PI = 3.142;
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double AreaOfacircle(double radius)
        {
            return PI * radius * radius;
        }
    }

    public record LoginDto(string username, string password);

    public class Dto
    {
        public Dto(string username, string password)
        {
            Username = username;
            Password = password;

        }
        public string Username { get; init; }

        public string Password { get; init; }
    }
    
}