public class Item
{
    public string Name { get; }
    private bool IsPokeball { get; }
    private int Amount { get; set; }

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
}