public class Charmander : Pokemon
{
    public Charmander(string nickname) : base("Charmander", nickname, "Fire", null, "Growl")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound() + "!");
    }
}