Student student1 = new Student();

Console.WriteLine("Студент 1:");
student1.PrintInfo();

Console.WriteLine();

Student student2 = new Student("Петър Петров Петров", 12345);

Console.WriteLine("Студент 2:");
student2.PrintInfo();

Console.WriteLine();

Student student3 = new Student(
    "Мария Иванова Георгиева",
    54321,
    "Компютърни науки",
    2);

Console.WriteLine("Студент 3:");
student3.PrintInfo();

Console.ReadKey();
