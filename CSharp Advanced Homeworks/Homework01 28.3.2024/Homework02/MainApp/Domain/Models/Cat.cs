namespace MainApp.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }
        public Cat(string name, int age, bool lazy, int livesLeft)
       : base(name, "Cat", age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Cat Name: {Name}, Type: {Type}, Age: {Age}, Lazy: {Lazy}, Lives Left: {LivesLeft}");
        }
    }
}