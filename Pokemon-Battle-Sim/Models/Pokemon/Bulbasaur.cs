public class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base("Bulbasaur", nickname, TypeOfPokemon.Grass, null, "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound() + "!!!");
    }
}