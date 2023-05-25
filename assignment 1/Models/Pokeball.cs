public class Pokeball
{
    public string TypePokeball { get; }
    public Pokemon? Pokemon { get; set; }
    // no moves yet

    public Pokeball(Pokemon? pokemon, string typePokeball = "Pokeball")
    {
        Pokemon = pokemon;
        TypePokeball = typePokeball;
    }

    public Pokemon SelectPokemon()
    {
        Console.WriteLine(Pokemon.Nickname + ", I choose you!");
        Pokemon.BattleCry();
        var TempPokemon = Pokemon;
        Pokemon = null;
        return TempPokemon;
    }

    public bool ReturnPokemon(Pokemon chosenPokemon)
    {
        
        if (Pokemon == null)
        {
            Console.WriteLine(chosenPokemon.Nickname + ", Come back!");
            Pokemon = chosenPokemon;
            return true;
        } else {
            Console.WriteLine(Pokemon.Nickname + ", has already occupied this pokeball!");
            return false;
        }
            

    }
}