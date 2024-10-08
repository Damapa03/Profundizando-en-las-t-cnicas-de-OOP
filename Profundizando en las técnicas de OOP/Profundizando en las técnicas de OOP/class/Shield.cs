namespace Profundizando_en_las_técnicas_de_OOP.@class;

public class Shield: Protection
{
    public new const int DefaultArmor = 10;
    public Shield(int armor = DefaultArmor) : base(armor)
    {
        Name = "Shield";
    }
    
}