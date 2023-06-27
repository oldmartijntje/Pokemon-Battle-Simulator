public class Program
{
    static void Main()
    {
        

        // vorig gebeuren
        string sound = "skreeeeeeeeeeeeee";
        Console.WriteLine("Enter a name for player 1:");
        string name = Console.ReadLine();
        List<Pokeball> emptyList = new List<Pokeball>();
        Trainer player1 = new Trainer(name, emptyList);
        Console.WriteLine("Enter a name for player 2:");
        name = Console.ReadLine();
        emptyList = new List<Pokeball>();
        Trainer player2 = new Trainer(name, emptyList);
        for (int i = 0; i < 2; i++)
        {
            player1.AddPokeballToBelt(new Pokeball(new Charmander("Koos Naamloos")));
            player2.AddPokeballToBelt(new Pokeball(new Charmander("Spongebob")));
        }
        for (int i = 0; i < 2; i++)
        {
            player1.AddPokeballToBelt(new Pokeball(new Squirtle("Donald mTrumpet")));
            player2.AddPokeballToBelt(new Pokeball(new Squirtle("Cola")));
        }
        for (int i = 0; i < 2; i++)
        {
            player1.AddPokeballToBelt(new Pokeball(new Bulbasaur("MIO")));
            player2.AddPokeballToBelt(new Pokeball(new Bulbasaur("Dolfy Itler")));
        }
        
        Battle currentBattle = new Battle(10, player1, player2);
        currentBattle.PlayFullGame();

    }

    
}