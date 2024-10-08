    
    using Profundizando_en_las_técnicas_de_OOP.@class;

    var character = new Character("Fran");
    var Minion = new Minion("Juanjo", character.Name);
    var Sword = new Sword();
    var MagicSword = new MagicSword(Minion);
    var Shield = new Shield();
    
    character.AddItem(Sword);
    character.AddItem(MagicSword);
    character.AddItem(Shield);
    character.AddMinion();
    
    Console.WriteLine("Manual Test");
    Console.WriteLine(character);
    
    character.RemoveItem(Sword);
    character.RemoveMinion(Minion);
    
    Console.WriteLine(character);
    
    character.RecieveDamage(10);
    Console.WriteLine(character);
    
    character.Healing(3);
    Console.WriteLine(character);
    