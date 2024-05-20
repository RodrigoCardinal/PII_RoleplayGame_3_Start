using System.Collections.Generic;
namespace RoleplayGame
{
    public class GoodKnight: AHeroes
    {
        public GoodKnight(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Sword());
            this.AddItem(new Helmet());
        }
    }
}