
public class Weapon : Item
{
public int MaxDamage = 25; 
public int MinDamage = 10; 

public int Attack()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}
