﻿public class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base("Squirtle", nickname, TypeOfPokemon.Water, null, "Meow")
    {

    }

    public override void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound() + "! " + this.GetSound() + "! " + this.GetSound() + "! " + this.GetSound() + "! " + this.GetSound() + "! " + this.GetSound() + "! ");
    }
}