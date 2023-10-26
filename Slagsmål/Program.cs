SubZero sub = new SubZero();
sub.weapon = new Icicle();
sub.name = "SubZero";

Scorpion Scorp = new Scorpion();
Scorp.name = "Scorpion";
Scorp.weapon = new KunaiRopeDart();
Scorp.weapon.name = "Kunai Rope Dart";


Random generator = new Random();

while (Scorp.hp > 0 & sub.hp > 0)
{
  Console.WriteLine($"{Scorp.name}:{Scorp.hp} || {sub.name}: {sub.hp}"); 

  Scorp.Attack(sub);
  sub.Attack(Scorp);
}

if (Scorp.hp == 0 & sub.hp == 0)
{
 Console.WriteLine($"DRAW");
}
else if (sub.hp == 0)
{
  Console.WriteLine($"FATALITY! Sub-Zero WINS!");
}
else 
{
  Console.WriteLine($"FATALITY! Scorpion WINS!");
}

Console.ReadLine();