public class Dwayne : Pokemon
{
    public Dwayne(string nickname) : base("Dwayne", nickname, "Rock", null, "- Dwayne \"The Rock\" Johnson")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": Success at anything will always come down to this: focus and effort. And we control both. " + this.GetSound());
    }
}