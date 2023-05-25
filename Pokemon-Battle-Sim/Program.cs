public class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a name for your Charmander:");
        string name = Console.ReadLine();
        Charmander charmander = new Charmander(name, 5);
        Pokeball pokeball = new Pokeball(charmander);
        var belt = new List<Pokeball> { pokeball, pokeball, pokeball, pokeball, pokeball, pokeball, pokeball };
        Trainer henk = new Trainer("henk", belt);
        for (int i = 0; i < 10; i++)
        {
            Pokemon selected = pokeball.SelectPokemon();
            pokeball.ReturnPokemon(selected);
            pokeball.ReturnPokemon(selected);
        }
        Console.ReadLine();

    }
}