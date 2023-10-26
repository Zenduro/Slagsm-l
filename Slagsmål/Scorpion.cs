

public class Scorpion
{
  public int hp = 80000;
  public string name;
  public KunaiRopeDart weapon;

  public void Attack(SubZero target) 
  {
    int damage = weapon.GetDamage();
    target.hp = Math.Max(0, target.hp);
    target.hp -= damage;
    Console.WriteLine($"{name} did {damage} to {target.name}");
  }
}
