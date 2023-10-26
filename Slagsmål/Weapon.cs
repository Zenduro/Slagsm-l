public class Weapon
{
    public string name;
    private Random generator;
    public Weapon()
    {
        generator = new Random();
    }

    public int minDamage = 420;
    public int maxDamage = 6969;
    public int GetDamage()
    {
        return generator.Next(minDamage, maxDamage);
    }
}
