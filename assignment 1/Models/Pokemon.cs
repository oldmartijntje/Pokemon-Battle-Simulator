public class Pokemon
{
    public string Name { get; }
    public string Nickname { get; set; }
    public string Type { get; }
    public string? Item { get; set; }
    public string Weakness { get; set; }
    public string Sound { get; }
    // no moves yet

    public Pokemon(string name, string? nickname, string type, string item, string sound)
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
        Item = item;
        Sound = sound;
    }

    public void BattleCry()
    {
        Console.WriteLine(Nickname + ": " + Sound + "!");
    }

   
}