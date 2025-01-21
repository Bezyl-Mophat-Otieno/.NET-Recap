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


    class Program
    {
        static void Main(string[] args)
        {
            Car myFirsCar = new Car("Audi", "C30", 2025);
            Console.WriteLine($"My car make: {myFirsCar.Make}");
            Console.WriteLine($"My car model: {myFirsCar.Model}");
            myFirsCar.DisplayInfo();

            Dog mydog = new Dog
            {
                name = "Bosco"
            };
            mydog.speak();
            Cat mycat = new Cat
            {
                name = "annita"
            };
            mycat.speak();
            var circle = new Circle { radius = 7.0 };
            Console.WriteLine($"The area of the circle: {circle.Area()}");

            var student1 = new Student
            {
                CurrentClass = "4East",
                TotalScoredMarks = 800,
                YearOfBirth = 2007,
            };

            student1.PercentageScore(1000);

            Tenant tenant31 = new Tenant("John Doe", 31);
            tenant31.BookingInformation();
            Tenant tenant29 = new Tenant("Bezyl Mophat");
            tenant29.BookingInformation();

            if (tenant29 is Tenant)
            {
                Console.WriteLine("I am a tenant" + tenant29.ToString());
            }

            Console.WriteLine(MathUtilities.Add(20, 30));
            Console.WriteLine(MathUtilities.AreaOfacircle(21));

            var name = "Mophat";

            if (name is string lastname)
            {
                Console.WriteLine("LastName: " + lastname);
            }
            var LoginRequest1 = new LoginDto("johnDoe", "1287854");
            var LoginRequest2 = new LoginDto("johnDoe", "1287854");
            var LoginRequest3 = new Dto("Bezyl Mophat", "8479384");
            var LoginRequest4 = new Dto("Bezyl Mophat", "8479384");


            Console.WriteLine(LoginRequest1 == LoginRequest2);
            Console.WriteLine(LoginRequest3 == LoginRequest4);


            var valueTupple1 = (Yob: 1, name: "Mophat", isSuccess: true);
            Console.WriteLine(valueTupple1.Item1);
            Console.WriteLine(valueTupple1.Item2);
            Console.WriteLine(valueTupple1.Item3);
            var person = (Name: "Alice", Age: 30);
            Console.WriteLine($"Before: {person.Name}, Age: {person.Age}");

            person.Name = "Mophat";
            person.Age = 31;

            Console.WriteLine($"After: {person.Name}, Age: {person.Age}");

            var tupleExample = new Tuple<string, int>("Mophat", 31);
            // tupleExample.Item1 = "Bezyl"; // This will throw an error

            var studentDictionary = new Dictionary<int, string>{
                {1,"John Doe"},
                {2,"John Lebron James"},
                {3,"John Mark Zukerberg"}
            };
            studentDictionary[4] = "John Pombe Magufuli";
            studentDictionary.Add(5, "Mama samia suluhu");

            if(studentDictionary.ContainsKey(5)){
                Console.WriteLine(studentDictionary[5]);
            }

            foreach (var kyv in studentDictionary)
            {
                Console.WriteLine($"Key: {kyv.Key}, Value: {kyv.Value}");
                
            }


            Console.WriteLine(studentDictionary[4]);

            var hashSet = new HashSet<string>
            {
                "Mophat",
                "Bezyl",
                "Mophat",
                "Bezyll"
            };

            Console.WriteLine(hashSet.Count);

            var hashSet1 = new HashSet<int>
            {
                1,2,3,4
            };

            foreach ( var  item in hashSet1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Added: {hashSet1.Add(5)}");

            var hashSet2 = new HashSet<int>
            {
                3,4,5,6
            };

            foreach ( var  item in hashSet2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Added: {hashSet2.Add(6)}");
            Console.WriteLine("Union of hashSet1 and hashSet2");
            var combinedHashSet = hashSet1.Union(hashSet2);
            foreach ( var  item in combinedHashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Intersect of hashSet1 and hashSet2");
            var intersectedHashSet = hashSet1.Intersect(hashSet2);
            foreach ( var  item in intersectedHashSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Except of hashSet1 and hashSet2");
            var exceptedHashSet = hashSet1.Except(hashSet2);
            foreach ( var  item in exceptedHashSet)
            {
                Console.WriteLine(item);
            }




        }
    }
}

