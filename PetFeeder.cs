namespace VirtualPet
{
    internal class PetFeeder
    {
        public static void Run(Pet[] Pets)
        {
            for (var index = 0; index < Pets.Length; index++)
            {
                var pet = Pets[index];
                Console.WriteLine($"Dette er {pet.Name}\r\n{pet.Name} er hund nummer {index + 1}\r\n{pet.Name} er {pet.Belly} lang \r\n{pet.Name}s favorittmat er {pet.Favorite}");
                pet.MakeDog();
            }

            Console.WriteLine("Skriv tallet på hunden du vil mate, og trykk enter");
            var dogIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            if (dogIndex >= 0 && dogIndex <= Pets.Length)
            {
                Console.WriteLine($"{Pets[dogIndex].Name} synes {Pets[dogIndex].Favorite} er digg, men for mye av det gode...\r\n Vil du gi {Pets[dogIndex].Name} {Pets[dogIndex].Favorite}?\r\n y/n");
                var yesno = Console.ReadLine();
                if (yesno.Equals("y") || yesno.Equals("yes"))
                {
                    Pets[dogIndex].FeedDog(true);
                }
                else Pets[dogIndex].FeedDog();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Oi. Veit ikke om jeg eller du gjorde feil, men jeg fant ikke den hunden");
            }
            
            Run(Pets);
        }
    }
}
