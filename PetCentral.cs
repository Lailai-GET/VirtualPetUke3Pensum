namespace VirtualPet
{
    internal class PetCentral
    {
        public List<Pet> Pets;
        public PetFeeder Feeder;

        public PetCentral()
        {
            Pets = new List<Pet>();
            Feeder = new PetFeeder();
            GeneratePets();
            Feeder.Run(Pets);
        }
        public void PetMaker(string name, string favorite)
        {
            Pets.Add(new Pet(name, favorite));
        }
        public void GeneratePets()
        {
            Console.WriteLine("Hvor mange hunder vil du ha?(skriv et tall og trykk 'enter')");
            int petCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < petCount; i++)
            {
                Console.Clear();
                Console.WriteLine($"Hva heter hund nummer {i + 1}?");
                var userName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Hva er {userName}s favorittmat?");
                var userFood = Console.ReadLine();
                PetMaker(userName, userFood);
            }
        }
    }
}
