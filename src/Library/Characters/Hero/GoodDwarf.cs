using System.Collections.Generic;
namespace RoleplayGame
{
    public class GoodDwarf: AHeroes
    {
        public GoodDwarf(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Axe());
        }
    }
}