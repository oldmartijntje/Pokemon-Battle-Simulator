public abstract class Pokemon
{
    private string Name;
    private string Nickname;
    private TypeOfPokemon Type;
    //private Item? Item;
    private string Sound;

    public Pokemon(string name, string? nickname, TypeOfPokemon type, Item? item, string sound)
    {
        Name = name;
        if (nickname == null || nickname == "")
        {
            Nickname = Name;
        } else
        {
            Nickname = nickname;
        }
        Type = type;
        //this.Item = item;
        Sound = sound;
    }

    public abstract void BattleCry();

    /*public bool EquipItem(Item item)
    {
        if (Item == null)
        {
            this.Item = item;
            Console.WriteLine(this.GetNickname() + " has equipped " + Item.GetAmount() + "X " + Item.GetName() + ".");
            return true;
        } else if (this.Item.GetPokemonType() == item.GetPokemonType()) 
        {
            this.Item.SetAmount(this.Item.GetAmount() + item.GetAmount());
            Console.WriteLine(this.GetNickname() + " has equippped " + item.GetAmount() + " more " + Item.GetName() + ", total is: " + this.Item.GetAmount() + ".");
            return true;
        } else {
            Console.WriteLine(this.GetNickname() + " tried to equip " + item.GetAmount() + "X " + item.GetName() + ", but failed because he already carries " + Item.GetAmount() + "X " + Item.GetName() + ".");
            return false;
        }
    }*/

    public void SetNickname(string newName)
    {
        Nickname = newName;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetNickname()
    {
        return Nickname;
    }

    public TypeOfPokemon GetPokemonType()
    {
        return Type;
    }

    public string GetSound()
    {
        return Sound;
    }

    /*public Item? GetEquippedItem()
    {
        return this.Item;
    }*/

    /*public Item UnequipItem()
    {
        Item temp = this.Item;
        this.Item = null;
        return temp;
    }*/

    public void ChangeSound(string sound)
    {
        this.Sound = sound;
    }

    public enum TypeOfPokemon
    {
        Fire,
        Water,
        Grass
    }

    public static Dictionary<TypeOfPokemon, List<TypeOfPokemon>> TypeCompatibility = new Dictionary<TypeOfPokemon, List<TypeOfPokemon>>()
    {
        { TypeOfPokemon.Fire, new List<TypeOfPokemon> { TypeOfPokemon.Grass } },
        { TypeOfPokemon.Water, new List<TypeOfPokemon> { TypeOfPokemon.Fire } },
        { TypeOfPokemon.Grass, new List<TypeOfPokemon> { TypeOfPokemon.Water } }
    };

}