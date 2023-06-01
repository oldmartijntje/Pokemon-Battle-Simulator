public class Gasoline : Item
{
    public int BoostAmount { get; }
    private string TypeOfBoost { get; }
    private string HasEffectOnType { get; set; }

    public Gasoline(int amount) : base("Gasoline", amount, false)
    {
        
    }

}