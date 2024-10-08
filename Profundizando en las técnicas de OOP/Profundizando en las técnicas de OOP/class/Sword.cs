namespace Profundizando_en_las_técnicas_de_OOP.@class;

public class Sword : Weapon
{
    public new const int  DefaultDamage = 10;

    public Sword(int damage = DefaultDamage): base(damage)
    {
        Name = "Sword";
    }
}