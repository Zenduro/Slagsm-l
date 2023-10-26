

public class SubZero
{
  public int hp = 80000;
  public Weapon weapon;  
  public string name;

  public void Attack(Scorpion target)
  {
    int damage = weapon.GetDamage();
    target.hp = Math.Max(0, target.hp);
    target.hp -= damage;
    Console.WriteLine($"{name} did {damage} to {target.name}");
  }
}
