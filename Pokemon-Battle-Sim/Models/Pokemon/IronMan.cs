public class IronMan : Pokemon
{
    public IronMan(string nickname) : base("Bulbasaur", nickname, "Grass", null, "I am ")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": To turn over the Iron Man suit would be to turn over myself. " + this.GetSound() + this.GetNickname() + "!");
    }
}