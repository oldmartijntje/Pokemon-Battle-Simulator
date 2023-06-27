public class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base("Bulbasaur", nickname, "Grass", null, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "Fire")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound() + "!!!");
    }
}