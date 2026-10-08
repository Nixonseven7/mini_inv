
public class Consumable : Item
{
    public int UsesMax = 5;
    public int UsesCurrent = 5;

    public void Use(Character target)
    {
        if(UsesCurrent > 0)
        {
            target.hp +=10;
            UsesCurrent --;
        } 
    }
}
