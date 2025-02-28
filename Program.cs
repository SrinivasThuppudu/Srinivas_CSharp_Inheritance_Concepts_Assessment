// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine();

Console.WriteLine("-------------------------First Program------------------------------");
Car car = new Car { Brand = "Mercedez", Speed = 300 };
Bike bike = new Bike { Brand = "Classic 360", Speed = 180 };
car.DisplayInfo();
bike.DisplayInfo();
Console.WriteLine();

Console.WriteLine("-------------------------Second Program-----------------------------");
Car1 c1 = new Car1 { Brand1 = "Toyota", Speed1 = 120, NumberOfDoors = 4 };
Bike1 b1 = new Bike1 { Brand1 = "Yamaha", Speed1 = 80, Fuel_type = "Petrol" };
c1.DisplayInfo();
b1.DisplayInfo();
Console.WriteLine();

Console.WriteLine("-------------------------Third Program------------------------------");
Manager manager = new Manager("Srini", 75000, 5000);
Console.WriteLine($"Manager: {manager.Name}, Salary: {manager.Salary}, Bonus: {manager.Bonus}");
Console.WriteLine();

Console.WriteLine("-------------------------Fourth program-----------------------------");
Animal myDog = new Dog();
Animal myCat = new Cat();
myDog.MakeSound();
myCat.MakeSound();
Console.WriteLine();

Console.WriteLine("--------------------------Fifth Program-----------------------------");
Robot robot = new Robot();
robot.Start();
robot.Move();
Console.WriteLine();

Console.WriteLine("---------------------------Sixth Program----------------------------");
// Account account = new Account();
// account.CalculateInterest();
SavingsAccount savingsAccount = new SavingsAccount();
savingsAccount.CalculateInterest();
Console.WriteLine();

Console.WriteLine("---------------------------Seventh Program--------------------------");
Duck duck = new Duck();
duck.Fly();
duck.Swim();
Console.WriteLine();

Console.WriteLine("---------------------------Eighth Program--------------------------");
Student student = new Student { Name = "Srini", Age = 21, StudentID = 6218 };
// Upcast Student to Person
Person person = student;
person.DisplayInfo();
// Downcast Person back to Student
Student downcastedStudent = (Student)person;
downcastedStudent.DisplayStudentInfo();
Console.WriteLine();

Console.WriteLine("---------------------------Ninth Program---------------------------");
Product laptop = new ElectronicProduct { Name = "Laptop", Price = 1000 };
Product shirt = new ClothingProduct { Name = "Shirt", Price = 50 };
Console.WriteLine($"{laptop.Name} discounted price: {laptop.GetDiscountedPrice()}");
Console.WriteLine($"{shirt.Name} discounted price: {shirt.GetDiscountedPrice()}");
Console.WriteLine();

Console.WriteLine("---------------------------Tenth Program---------------------------");
SecuritySystem securitySystem = new SecuritySystem();
securitySystem.AuthenticateUser();
