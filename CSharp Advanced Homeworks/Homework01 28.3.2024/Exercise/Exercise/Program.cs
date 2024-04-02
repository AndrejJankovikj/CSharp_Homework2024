using Exercise.Classes;
Teacher teacher1 = new Teacher(1, "Danilo", "Danilo123", new List<string>
{
    "English",
    "Physics",
    "Biology",
    "Math"
});
teacher1.PrintUser();



Teacher teacher2 = new Teacher(2, "Ilija", "Ilija223", new List<string>
{
    "Sport",
    "Music",
    "Art",
    "Ping-Pong",
    "Survival Education"
});
teacher2.PrintUser();

Student student1 = new Student(3, "Andrej", "Jankovikj", new List<int>
{
    5,1,4,3,2
});
student1.PrintUser();

Student student2 = new Student(3, "Viktor", "Zdravkovski", new List<int>
{
    2,5,5,4,4
});
student2.PrintUser();