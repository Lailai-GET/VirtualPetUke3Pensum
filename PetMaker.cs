namespace VirtualPet
{
    internal class PetMaker
    {
        public Pet[] Pets { get; private set; }
        private string[] _names;
        private string[] _foods;

        public PetMaker(int petCount, string[] userNames, string[] userFoods)
        {
            Pets = new Pet[petCount];
            _names = userNames;
            _foods = userFoods;
            for (int i = 0; i < Pets.Length; i++)
            {
                Pets[i] = new Pet(_names[i], _foods[i]);
            }

        }
        public static PetMaker GeneratePets()
        {
            Console.WriteLine("Hvor mange hunder vil du ha?(skriv et tall og trykk 'enter')");
            int petCount = Convert.ToInt32(Console.ReadLine());
            string[] userNames = new string[petCount];
            string[] userFoods = new string[petCount];
            for (int i = 0; i < userNames.Length; i++)
            {
                Console.WriteLine($"Hva heter hund nummer {i + 1}?");
                userNames[i] = Console.ReadLine();
            }

            for (int i = 0; i < userFoods.Length; i++)
            {
                Console.WriteLine($"Hva er {userNames[i]}s favorittmat?");
                userFoods[i] = Console.ReadLine();
            }
            Console.Clear();
            var petMaker = new PetMaker(petCount, userNames, userFoods);
            return petMaker;
        }


    }
}
