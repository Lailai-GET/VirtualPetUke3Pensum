namespace VirtualPet
{
    internal class Pet
    {
        public string Name { get; private set; }
        public int Belly { get; private set; }
        public string Favorite { get; private set; }

        public Pet(string name, string favorite)
        {
            Name = name;
            Belly = 1;
            Favorite = favorite;
        }


        public void PrintDog()
        {
            int petPad = Belly;
            string spacePad = " ";
            string underPad = "_";
            if (Belly < 100)
            {
                Console.WriteLine(
                    $"         {spacePad.PadLeft(petPad, ' ')}     .-.\r\n     (___{underPad.PadLeft(petPad, '_')}___()6 `-,\r\n     (   {underPad.PadLeft(petPad, '_')}   /''\"`\r\n     //\\\\{spacePad.PadLeft(petPad, ' ')} //\\\\\r\n     \"\" \"\"{spacePad.PadLeft(petPad, ' ')}\"\" \"\"");
            }
            else Console.WriteLine($"{Name} er død av for mye {Favorite}");
        }

        public void FeedDog()
        {
            Console.Clear();
            Console.WriteLine($"{Name} er ikke særlig begeistret, men spiser maten likevel...");
            Belly++;

        }

        public void FeedDog(bool favorite)
        {
            Console.Clear();
            Console.WriteLine($"{Name} er superglad og spiser {Favorite} så fort at du ikke ser hvor det blir av!");
            Belly = Belly + 10;
        }
    }
}
