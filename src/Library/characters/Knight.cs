using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Caballero
    /// </summary>
    public class Knight : Character
    {
        public Knight(string name)
            : base(name)
        {
            this.Health = 200;
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Helmet());
        
        }
    }
}