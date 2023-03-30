namespace VirtualPet
{
    internal class PetFeeder
    {
        public void Run(List<Pet> Pets)
        {
            PetDetails(Pets);
            Console.WriteLine("Skriv tallet på hunden du vil mate, og trykk enter");
            var petIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (petIndex >= 0 && petIndex < Pets.Count)
            {
                Console.WriteLine($"{Pets[petIndex].Name} synes {Pets[petIndex].Favorite} er digg, men for mye av det gode...\r\n Vil du gi {Pets[petIndex].Name} {Pets[petIndex].Favorite}?\r\n y/n");
                var yesno = Console.ReadLine();
                if (yesno.Equals("y") || yesno.Equals("yes"))
                {
                    Pets[petIndex].FeedPet(true);
                }
                else Pets[petIndex].FeedPet();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Oi. Veit ikke om jeg eller du gjorde feil, men jeg fant ikke den hunden");
            }
            Run(Pets);
        }
        private void PetDetails(List<Pet> Pets)
        {
            for (var index = 0; index < Pets.Count; index++)
            {
                var pet = Pets[index];
                pet.PetInfo(index);
                pet.PrintPet();
            }
        }
    }
}
