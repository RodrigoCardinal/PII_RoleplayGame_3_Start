using System.Collections.Generic;
namespace RoleplayGame
{
    public class GoodArcher: AHeroes
    {
        public GoodArcher(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}