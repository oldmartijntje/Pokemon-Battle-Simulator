public class Arena
{
    private int Rounds;
    private int AmountOfBattles;
    private Battle CurrentBattle;
    public Arena(Battle battle)
    {
        Rounds = 0;
        AmountOfBattles = 0;
        CurrentBattle = battle;

    }

    public void StartBattle()
    {
        Random random = new Random();
        this.CurrentBattle.SetRoundsToPlay(random.Next(4, 10));
        this.CurrentBattle.PlayFullGame();
        this.Rounds += this.CurrentBattle.GetRoundsPlayed();
        this.AmountOfBattles++;
    }

    public void PrintStatistics()
    {
        Console.WriteLine("\n--------\nAmount of rounds played: " + this.Rounds + "\nAmount of Battles: "+ this.AmountOfBattles + "\n--------\n");
    }

}