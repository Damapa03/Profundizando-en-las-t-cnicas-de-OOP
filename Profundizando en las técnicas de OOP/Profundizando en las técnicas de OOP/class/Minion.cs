namespace Profundizando_en_las_técnicas_de_OOP.@class;

public class Minion()
{
    public string Name { get; set; }
    public const int MaxHitPoints = 1;
    public int HitPoints { get; set; }
    public const int BaseDamage = 3;
    public int Damage { get; set; }
    public const int BaseArmor = 0;
    public int Armor { get; set; }
    public string MasterName { get; set; }

    public Minion(string name, string masterName, int hitPoints = MaxHitPoints, int damage = BaseDamage, int armor = BaseArmor) : this()
    {
        Name = name;
        HitPoints = hitPoints;
        Damage = damage;
        Armor = armor;
        MasterName = masterName;
    }

    public int Attack()
    {
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
    }

    public void Healing(int amount)
    {
        
    }

    public void RecieveDamage(int damage)
    {
        
    }
}