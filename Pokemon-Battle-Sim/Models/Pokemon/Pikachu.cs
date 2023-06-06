public class Pikachu : Pokemon
{
    public Pikachu(string nickname) : base("Pikachu", nickname, "Electricity", null, "Pika Pika, PIKACHUUUUUUUUUUUUU!!!")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound());
    }
}