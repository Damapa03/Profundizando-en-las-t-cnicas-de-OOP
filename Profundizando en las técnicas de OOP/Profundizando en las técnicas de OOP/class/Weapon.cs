using Profundizando_en_las_técnicas_de_OOP.@interface;

namespace Profundizando_en_las_técnicas_de_OOP.@class;

public abstract class Weapon : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public const int DefaultDamage = 5;

    protected Weapon(int damage = DefaultDamage)
    {
        Damage = damage;
    }

    public void Apply(Character character)
    {
        character.Damage += Damage;
    }

    public void ApplyMinion(Character character){}
    public override string ToString()
    {
        return $"Weapon Name: {Name}, Damage: {Damage}";
    }
}