namespace MainApp.Domain.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public Dog(string name, int age, bool goodBoy, string favoriteFood)
            : base(name, "Dog", age)
        {
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Dog Name: {Name}, Type: {Type}, Age: {Age}, Good Boy: {GoodBoy}, Favorite Food: {FavoriteFood}");
        }
    }
}