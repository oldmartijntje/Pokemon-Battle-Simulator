public class Pokemon
{
    private string Name;
    private string Nickname;
    private string Type;
    private Item? Item;
    private string Sound;
    // no moves yet

    public Pokemon(string name, string? nickname, string type, Item? item, string sound)
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
        this.Item = item;
        Sound = sound;
    }

    public void BattleCry()
    {
        Console.WriteLine(this.GetNickname() + ": " + this.GetSound() + "!");
    }

    public bool EquipItem(Item item)
    {
        if (Item == null)
        {
            this.Item = item;
            Console.WriteLine(this.GetNickname() + " has equipped " + Item.GetAmount() + "X " + Item.GetName() + ".");
            return true;
        } else if (this.Item.GetType() == item.GetType()) 
        {
            this.Item.SetAmount(this.Item.GetAmount() + item.GetAmount());
            Console.WriteLine(this.GetNickname() + " has equippped " + item.GetAmount() + " more " + Item.GetName() + ", total is: " + this.Item.GetAmount() + ".");
            return true;
        } else {
            Console.WriteLine(this.GetNickname() + " tried to equip " + item.GetAmount() + "X " + item.GetName() + ", but failed because he already carries " + Item.GetAmount() + "X " + Item.GetName() + ".");
            return false;
        }
    }

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

    public string GetType()
    {
        return Type;
    }

    public string GetSound()
    {
        return Sound;
    }

    public Item? GetEquippedItem()
    {
        return this.Item;
    }


   
}