using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilKnight : AVillan
    {
        public EvilKnight(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Sword());
            this.AddItem(new Helmet());
            this.AddItem(new Shield());

            this.VictoryPoints = 2;
        }
    }
}