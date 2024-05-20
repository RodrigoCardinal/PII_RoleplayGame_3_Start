using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class AVillan : ACharacter
    {
        public int victoryPoints;

        public int VictoryPoints 
        {
            get
            {
                return this.victoryPoints;
            } 
            set
            {
                this.victoryPoints = value;
            }
        }
    }
}