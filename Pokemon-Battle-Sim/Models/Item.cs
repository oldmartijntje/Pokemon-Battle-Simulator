public class Item
{
    private string Name;
    private bool IsPokeball;
    private int Amount;

    public Item(string name, int amount, bool isPokeball)
    {
        Name = name;
        Amount = amount;
        IsPokeball = isPokeball;
    }

    public int GetAmount()
    {
        return Amount;
    }

    public bool CheckForPokeball()
    {
        return IsPokeball;
    }

    public void SetAmount(int number)
    {
        this.Amount = number;
    }

    public string GetName()
    {
        return Name;
    }
}