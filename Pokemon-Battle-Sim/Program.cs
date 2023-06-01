public class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a name for your Charmander:");
        string name = Console.ReadLine();
        Charmander charmander = new Charmander(name);
        Pokeball pokeball = new Pokeball(charmander);
        var belt = new List<Pokeball> {  };
        Trainer henk = new Trainer("henk", belt);
        for (int i = 0; i < 10; i++)
        {
            Pokemon selected = pokeball.SelectPokemon(henk.Name);
            pokeball.SelectPokemon(henk.Name);
            pokeball.ReturnPokemon(selected, henk.Name);
            pokeball.ReturnPokemon(selected, henk.Name);
        }
        Item blag = new Item();
        Item blag2 = new Item();
        Item blag3 = new Item();
        pokeball.Pokemon.EquipItem(blag);
        pokeball.Pokemon.EquipItem(blag2);
        pokeball.Pokemon.EquipItem(blag3);
        henk.AssertDominance();
        henk.AssertDominance();
        Console.ReadLine();

    }
}