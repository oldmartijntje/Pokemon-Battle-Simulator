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

    public Pokemon? SelectPokemon(string trainerName)
    {
        Console.WriteLine(trainerName + " threw a " + TypePokeball);
        if (Pokemon == null)
        {
            Console.WriteLine(trainerName + ": That's akward, it's already empty.");
            return null;
        } 
        else
        {
            Console.WriteLine(trainerName + ": " + Pokemon.Nickname + ", I choose you!");
            Pokemon.BattleCry();
            var TempPokemon = Pokemon;
            Pokemon = null;
            return TempPokemon;
        }
    }

    public bool ReturnPokemon(Pokemon chosenPokemon, string trainerName)
    {
        
        if (Pokemon == null)
        {
            Console.WriteLine(trainerName + ": " + chosenPokemon.Nickname + ", Come back!");
            Pokemon = chosenPokemon;
            return true;
        } else {
            Console.WriteLine(trainerName + ": " + Pokemon.Nickname + " has already occupied this pokeball! " + chosenPokemon.Nickname + " doesn't fit in there with him.");
            return false;
        }
            

    }
}