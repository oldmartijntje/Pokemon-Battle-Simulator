public class Arena
{
    private static int Rounds = 0;
    private static int AmountOfBattles = 0;
    private Battle CurrentBattle;
    public Arena(Battle battle)
    {
        CurrentBattle = battle;

    }

    public void StartBattle()
    {
        Random random = new Random();
        this.CurrentBattle.SetRoundsToPlay(random.Next(4, 10));
        this.CurrentBattle.PlayFullGame();
        Arena.Rounds += this.CurrentBattle.GetRoundsPlayed();
        Arena.AmountOfBattles++;
    }

    public void PrintStatistics()
    {
        Console.WriteLine("\n--------\nAmount of rounds played: " + Arena.Rounds + "\nAmount of Battles: "+ Arena.AmountOfBattles + "\n--------\n");
    }

}