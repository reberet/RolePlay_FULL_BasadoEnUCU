using System.Collections.Generic;
using RoleplayGame.Items;
using Ucu.Poo.RoleplayGame;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Arquero
    /// </summary>
    public class Archer: Character
    {
        public Archer(string name)
            : base(name)
        {
            this.Health = 70;
            this.AddItem(new Bow());
            this.AddItem(new Armor());
            
        }
    }
}