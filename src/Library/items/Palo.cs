namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo con el que nace el troll
    /// </summary>
    public class Palo : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

    }
}