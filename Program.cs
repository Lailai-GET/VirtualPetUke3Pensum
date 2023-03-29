namespace VirtualPet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pets = PetMaker.GeneratePets();
            PetFeeder.Run(pets.Pets);

        }
            

        
    }
    
}