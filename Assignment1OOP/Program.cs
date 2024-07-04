namespace Assignment1OOP
{
    internal class Program
    {

        // 1.1 Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
        //    Then, write a C# program that prints out all the days of the week using this enum.
        public enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        // 2.1 Define a struct "Person" with properties "Name" and "Age".
        // Create an array of three "Person" objects and populate it with data.
        // Then, write a C# program to display the details of all the persons in the array.
        public struct Person
        {
            public string Name;
            public int Age;

            public Person(string name , int age) 
            {
                Name = name;
                Age = age;
            }

            public void display()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        // 3.1 Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
        // Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
        // Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        public enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        // 4.1 Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
        //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        public enum Permissions
        {
            None = 0, Read = 1, Write = 2, Delete = 4, Execute = 8
        }

        // 5.1 Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members.
        // Write a C# program that takes a color name as input from the user
        // and displays a message indicating whether the input color is a primary color or not.
        public enum Colors
        {
            Red, Green, Blue
        }

        // 6.1 Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
        // Write a C# program that takes two points as input from the user and calculates the distance between them.
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y) { X = x; Y = y; }
            public double CalculateDistance(Point otherPoint) 
            {
                double deltaX = X - otherPoint.X;
                double deltaY = Y - otherPoint.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }

        // 7.1 Create a struct called "Person" with properties "Name" and "Age".
        // Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        
        // same struct as Question 2

        static void Main(string[] args)
        {
            // 1.2 C# program that prints out all the days of the week using this enum.
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

            // 2.2 Create an array of three "Person" objects and populate it with data.
            // Then, write a C# program to display the details of all the persons in the array.
            #region Q2
            //int numberOfPersons;
            //Console.Write("Please enter number of People: ");
            //while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
            //{
            //    Console.Write("Invalid input. Please enter a valid positive number for the number of persons: ");
            //}

            //Person[] person = new Person[numberOfPersons];

            //for (int i = 0; i < numberOfPersons; i++)
            //{
            //    Console.Write($"Enter Person #{i+1} name: ");
            //    string name = Console.ReadLine();

            //    int age;
            //    Console.Write($"Enter Person #{i+1} age: ");
            //    while (!int.TryParse(Console.ReadLine(),out age) || age <= 0)
            //    {
            //        Console.Write("Invalid input. Please enter a valid positive number for the age: ");
            //    }
            //    person[i] = new Person(name, age);
            //}

            //// Display Persons data 
            //Console.WriteLine("\nDetails of all Persons: ");
            //foreach (Person P in person)
            //{
            //    P.display();
            //} 
            #endregion

            // 3.2 Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            // Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            #region Q3
            //Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();

            //Season season;
            //while (!Enum.TryParse(input, true, out season) || !Enum.IsDefined(typeof(Season), season))
            //{
            //    Console.Write("Invalid input. Please enter a valid season (Spring, Summer, Autumn, Winter): ");
            //    input = Console.ReadLine();
            //}

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //} 
            #endregion

            // 4.2 Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            #region Q4
            //Permissions userPermissions = Permissions.None;

            //// add permissions
            //AddPermission(ref userPermissions, Permissions.Read);
            //AddPermission(ref userPermissions, Permissions.Write);

            //Console.WriteLine($"Current permissions: {userPermissions}");

            //// check if a permission exists
            //Console.WriteLine($"Has Read permission: {HasPermission(userPermissions, Permissions.Read)}");
            //Console.WriteLine($"Has Execute permission: {HasPermission(userPermissions, Permissions.Execute)}");

            //// Remove a permission
            //RemovePermission(ref userPermissions, Permissions.Write);

            //Console.WriteLine($"Current permissions after removal: {userPermissions}"); 
            #endregion

            // 5.2 Write a C# program that takes a color name as input from the user
            // and displays a message indicating whether the input color is a primary color or not.
            #region Q5
            //Console.Write("Enter a color name (Red, Green, Blue): ");
            //string input = Console.ReadLine();

            //Colors color;
            //while (!Enum.TryParse(input, true, out color) || !Enum.IsDefined(typeof(Colors), color))
            //{
            //    Console.Write("Invalid input. Please enter a valid color name (Red, Green, Blue): ");
            //    input = Console.ReadLine();
            //}

            //if (IsPrimaryColor(color))
            //{
            //    Console.WriteLine($"{input} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //} 
            #endregion

            // 6.2 Write a C# program that takes two points as input from the user and calculates the distance between them.
            #region Q6
            //Console.WriteLine("Enter coordinates for the first point:");
            //double x1 = GetCoordinate("X");
            //double y1 = GetCoordinate("Y");
            //Point point1 = new Point(x1, y1);

            //Console.WriteLine("\nEnter coordinates for the second point:");
            //double x2 = GetCoordinate("X");
            //double y2 = GetCoordinate("Y");
            //Point point2 = new Point(x2, y2);

            //double distance = point1.CalculateDistance(point2);
            //Console.WriteLine($"\nDistance between the points: {distance:F2}"); 
            #endregion

            // 7.2 Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            #region Q7
            //int numberOfPersons;
            //Console.Write("Please enter number of People: ");
            //while (!int.TryParse(Console.ReadLine(), out numberOfPersons) || numberOfPersons <= 0)
            //{
            //    Console.Write("Invalid input. Please enter a valid positive number for the number of persons: ");
            //}

            //Person[] person = new Person[numberOfPersons];

            //for (int i = 0; i < numberOfPersons; i++)
            //{
            //    Console.Write($"Enter Person #{i + 1} name: ");
            //    string name = Console.ReadLine();

            //    int age;
            //    Console.Write($"Enter Person #{i + 1} age: ");
            //    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
            //    {
            //        Console.Write("Invalid input. Please enter a valid positive number for the age: ");
            //    }
            //    person[i] = new Person(name, age);
            //}

            //Person oldestPerson = FindOldestPerson(person);

            //Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} aged {oldestPerson.Age}."); 
            #endregion
        }

        // Method to add a permission
        public static void AddPermission(ref Permissions currentPermissions, Permissions permissionToAdd)
        {
            currentPermissions |= permissionToAdd;
        }

        // Method to remove a permission
        public static void RemovePermission(ref Permissions currentPermissions, Permissions permissionToRemove)
        {
            currentPermissions &= ~permissionToRemove;
        }

        // Method to check if a permission exists
        public static bool HasPermission(Permissions currentPermissions, Permissions permissionToCheck)
        {
            return (currentPermissions & permissionToCheck) == permissionToCheck;
        }

        // Method to check if a color is a primary color
        public static bool IsPrimaryColor(Colors color)
        {
            return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
        }
        
        // method to get point coordinates from the user
        private static double GetCoordinate(string coordinateName)
        {
            double coordinate;
            Console.Write($"Enter {coordinateName}: ");
            while (!double.TryParse(Console.ReadLine(), out coordinate))
            {
                Console.Write($"Invalid input. Enter a valid {coordinateName}: ");
            }
            return coordinate;
        }

        // method to find the oldest Person in array
        public static Person FindOldestPerson(Person[] persons)
        {
            Person oldest = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }
            return oldest;
        }
    }
}
