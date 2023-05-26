public class Trainer
{
    public string Name { get; }
    public List<Pokeball> Belt { get; set; }
    public Pokemon? ActivePokemon { get; set; }
    public int? ActivePokemonBeltId { get; set; }

    public Trainer(string name, List<Pokeball?> belt)
    {
        Belt = belt.Take(6).ToList();
        Name = name;
    }

    public bool AddPokeballToBelt(Pokeball pokeball)
    {
        if (Belt.Count + 1 > 6)
        {
            Console.WriteLine(this.Name + ": Sorry " + pokeball.Pokemon.Nickname + ", but my belt is already full. Your pokeball can't fit on my belt.");
            return false;
        }
        else
        {
            Belt.Add(pokeball);
            Console.WriteLine(this.Name + " puts a pokeball containing " + pokeball.Pokemon.Name + " on his belt.");
            return true;
        }
    }

    public Pokeball? SwitchPokemonOnBelt(Pokeball pokeball, int Id)
    {
        if (Id -1 > 5)
        {
            Console.WriteLine(this.Name + ": I can't have more than 6 pokeballs on my belt.");
            return null;
        }
        else
        {
            Pokeball temporaryPokemon = Belt[Id - 1];
            if (temporaryPokemon == null)
            {
                Console.WriteLine(this.Name + ": that slot is empty, i can't switch it.");
                return null;
            } else {
                Belt[Id - 1] = pokeball;
                Console.WriteLine(this.Name + " switched a pokeball from his belt with another one.");
                return temporaryPokemon;
            }

        }
    }
}
