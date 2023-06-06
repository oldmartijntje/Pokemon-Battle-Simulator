public class Pokeball
{
    private string TypePokeball;
    private Pokemon? Pokemon;
    // no moves yet

    public Pokeball(Pokemon? pokemon, string typePokeball = "Pokeball")
    {
        Pokemon = pokemon;
        TypePokeball = typePokeball;
    }

    public Pokemon? SelectPokemon(string trainerName)
    {
        Console.WriteLine(trainerName + " threw a " + this.GetPokeballType());
        if (this.GetPokemon() == null)
        {
            Console.WriteLine(trainerName + ": That's akward, it's already empty.");
            return null;
        } 
        else
        {
            Console.WriteLine(trainerName + ": " + this.GetPokemon().GetNickname() + ", I choose you!");
            this.GetPokemon().BattleCry();
            var TempPokemon = this.GetPokemon();
            this.SetPokemon(null);
            return TempPokemon;
        }
    }

    public bool ReturnPokemon(Pokemon chosenPokemon, string trainerName)
    {

        if (this.GetPokemon() == null)
        {
            Console.WriteLine(trainerName + ": " + chosenPokemon.GetNickname() + ", Come back!");
            this.SetPokemon(chosenPokemon);
            return true;
        }
        else if (chosenPokemon == null)
        {
            Console.WriteLine(trainerName + " tried to fill his Pokebll with CO2.");
            return false;
        } else {
            Console.WriteLine(trainerName + ": " + this.GetPokemon().GetNickname() + " has already occupied this pokeball! " + chosenPokemon.GetNickname() + " doesn't fit in there with him.");
            return false;
        }
            
    }

    private void SetPokemon(Pokemon? pokemon)
    {
        this.Pokemon = pokemon;
    }

    public Pokemon? GetPokemon()
    {
        return this.Pokemon;
    }

    public string GetPokeballType()
    {
        return this.TypePokeball;
    }

    public string GetPokemonNickname(string ifEmptyReturn = "Air")
    {
        if (this.GetPokemon() == null)
        {
            return ifEmptyReturn;
        }
        else
        {
            return this.GetPokemon().GetNickname();
        }
    }

    public string GetPokemonName(string ifEmptyReturn = "Air")
    {
        if (this.GetPokemon() == null)
        {
            return ifEmptyReturn;
        }
        else
        {
            return this.GetPokemon().GetName();
        }
    }
}