public class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a name for player 1:");
        string name = Console.ReadLine();
        List<Pokeball> emptyList = new List<Pokeball>();
        Trainer player1 = new Trainer(name, emptyList);
        Console.WriteLine("Enter a name for player 2:");
        name = Console.ReadLine();
        emptyList = new List<Pokeball>();
        Trainer player2 = new Trainer(name, emptyList);
        for (int i = 0; i < 6; i++)
        {
            player1.AddPokeballToBelt(new Pokeball(new Charmander("Koos Naamloos")));
            player2.AddPokeballToBelt(new Pokeball(new Charmander("Spongebob")));
        }
        while (true)
        {
            for (int i = 0; i < 6; i++)
            {
                player1.SelectPokemonFromBelt(i);
                player2.SelectPokemonFromBelt(i);
                player2.SelectPokemonFromBelt(i);
                player1.ActivePokemon.BattleCry();
                player2.ActivePokemon.BattleCry();
                player2.ActivePokemon.BattleCry();
                player1.PutPokemonBackInBall();
                player2.PutPokemonBackInBall();
                player2.PutPokemonBackInBall();
            }
            Console.WriteLine("Want them to torture their pokemon again? (Y) or want them to stop? (N)");
            string answer = Console.ReadLine();
            if (answer != "Y")
            {
                break;
            }
        }
        
        Console.ReadLine();
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
        henk.AssertDominance();
        henk.AssertDominance();
        Console.ReadLine();

    }
}