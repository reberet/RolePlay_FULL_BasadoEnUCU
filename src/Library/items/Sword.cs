namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada
    /// </summary>
    public class Sword : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 35;
            }
        }

    }
}