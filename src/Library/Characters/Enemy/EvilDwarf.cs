 using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilDwarf : AVillan
    {
        public EvilDwarf(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Axe());
            this.AddItem(new Shield());

            this.VictoryPoints = 2;
        }
    }
}