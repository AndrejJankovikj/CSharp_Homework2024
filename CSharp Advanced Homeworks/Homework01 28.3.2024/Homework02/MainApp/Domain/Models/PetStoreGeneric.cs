namespace MainApp.Domain.Models
{
    public class PetStoreGeneric<T> where T : Pet
    {
        private List<T> Pets = new List<T>();

        public void AddPet(T pet)
        {
            Pets.Add(pet);
        }
        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                pet.PrintInfo();
                Console.WriteLine();
            }
        }
        public void BuyPet(string petName)
        {
            T removePet = Pets.FirstOrDefault(t => t.Name == petName);
            if (removePet != null)
            {
                Console.WriteLine($"Congratulations you bought {petName}");
            }
            else
            {
                Console.WriteLine($"Sorry there is no pet named {petName}");
            }
        }
    }
}