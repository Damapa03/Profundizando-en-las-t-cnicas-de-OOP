using Profundizando_en_las_técnicas_de_OOP.@interface;

namespace Profundizando_en_las_técnicas_de_OOP.@class;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public const int DefaultArmor = 10;
    public int Armor { get; set; }

    public Protection(int armor = DefaultArmor)
    {
        Armor = armor;
    }
    public void Apply(Character character)
    {
        character.Armor += Armor;
    }

    public void ApplyMinion(Character character){}
    public override string ToString()
    {
        return $"Protection Name: {Name}, Armor: {Armor}";
    }
}