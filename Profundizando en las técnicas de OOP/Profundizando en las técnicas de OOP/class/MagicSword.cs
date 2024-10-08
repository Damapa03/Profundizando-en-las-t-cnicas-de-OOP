using Profundizando_en_las_técnicas_de_OOP.@class;

namespace Profundizando_en_las_técnicas_de_OOP.@class;

public class MagicSword: Weapon
{
    public Minion Minion { get; set; }
    public MagicSword(Minion minion, int damage = DefaultDamage) : base(damage)
    {
        Name = "Minion Sword";
        Minion = minion;
    }
    
    public void Apply(Character character)
    {
        character.Damage += Damage;
    }

    public new void ApplyMinion(Character character)
    {
        character.minions.Add(Minion);
    }
}