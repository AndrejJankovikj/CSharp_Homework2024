using Homework.Classes;
Console.ForegroundColor=ConsoleColor.DarkCyan;

Manager manager1 = new Manager("Mario", "Gulicovski", "ESZ");
Manager manager2 = new Manager("Martin", "Mitikj", "EBR");

Employee[] company = new Employee[5]
{
    new Contractor("Ivan","Apostolovski", 6,200, manager1),
    new Contractor("Danilo","Borozan",2,400, manager2),
    manager1,
    manager2,
    new SalesPerson("Ilija", "Mitev")
};

Ceo ceo = new Ceo("Andrej", "Jankovikj", company, 10000);
ceo.PrintInfo();
ceo.PrintEmployees();
ceo.GetSalary();