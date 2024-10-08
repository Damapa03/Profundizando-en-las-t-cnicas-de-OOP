using Profundizando_en_las_técnicas_de_OOP.@interface;

namespace Profundizando_en_las_técnicas_de_OOP.@class;

public class Character
{
    public string Name { get; set; }
    public const int MaxHitPoints = 10;
    public int HitPoints { get; set; }
    public const int BaseDamage = 5;
    public int Damage { get; set; }
    public const int BaseArmor = 5;
    public int Armor { get; set; }
    
    private List<IItem> _inventory;
    public List<Minion> minions;

    public Character(string name , int hitPoints = MaxHitPoints, int damage = BaseDamage, int armor = BaseArmor)
    {
        _inventory = new List<IItem>();
        minions = new List<Minion>();
        Name = name;
        HitPoints = hitPoints;
        Damage = damage;
        Armor = armor;
    }
    
    public void AddItem(IItem item) => _inventory.Add(item);
    public void RemoveItem(IItem item) => _inventory.Remove(item);
    public void AddMinion()
    {
        foreach (var item in _inventory)
        {
            item.ApplyMinion(this);
        }
    }
    public void RemoveMinion(Minion minion) => minions.Remove(minion);
    public int Attack() => BaseDamage;
    public int Defense() => BaseArmor;

    public void Healing(int amount)
    {
        if (HitPoints + amount > MaxHitPoints)
        {
            HitPoints = MaxHitPoints;
        }else HitPoints += amount;

    }
    public void RecieveDamage(int damage) => HitPoints -= damage - Armor;
    public override string ToString()
    {
        string result = $"Character: {Name} | HP: {HitPoints}/{MaxHitPoints}\n";
        result += "  Inventory:\n";
        foreach (var item in _inventory)
        {
            result += $"    {item}\n";
        }
        result += "  Minions:\n";
        foreach (var item in minions)
        {
            result += $"    {item}\n";
        }
        result += $"  Attack: {Attack()}\n";
        result += $"  Defense: {Defense()}\n";
        return result;
    }
}