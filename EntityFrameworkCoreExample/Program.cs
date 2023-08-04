using EntityFrameworkCoreExample;

StudentContext dbContext = new StudentContext();

// Add with EF Core
Student s = new Student()
{
    FullName = "Clark Kent",
    EmailAddress = "Clark.Kent@superman.com",
    DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new Student()
{
    FullName = "Klark Cent",
    EmailAddress = "Klark.Cent@mansuper.com",
    DateOfBirth = new DateTime(2000, 1, 2)
};

dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Executes pending insert. (IN ACTUALITY: execute any pending insert/update/delete queries).

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
                                                         // allStudents = (from stu in dbContext.Students select stu).ToList(); // Query syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}