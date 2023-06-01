public class Pokemon
{
    public string Name { get; }
    public string Nickname { get; set; }
    private string Type { get; }
    private Item? Item { get; set; }
    private string Sound { get; }
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
        Console.WriteLine(Nickname + ": " + Sound + "!");
    }

    public bool EquipItem(Item item)
    {
        if (Item == null)
        {
            this.Item = item;
            Console.WriteLine(Nickname + " has equipped " + Item.GetAmount() + "X " + Item.Name + ".");
            return true;
        } else if (this.Item.GetType() == item.GetType()) 
        {
            this.Item.SetAmount(this.Item.GetAmount() + item.GetAmount());
            Console.WriteLine(Nickname + " has equippped " + item.GetAmount() + " more " + Item.Name + ", total is: " + this.Item.GetAmount() + ".");
            return true;
        } else {
            Console.WriteLine(Nickname + " tried to equip " + item.GetAmount() + "X " + item.Name + ", but failed because he already carries " + Item.GetAmount() + "X " + Item.Name + ".");
            return false;
        }
    }

    public void SetNickname(string newName)
    {
        Nickname = newName;
    }


   
}