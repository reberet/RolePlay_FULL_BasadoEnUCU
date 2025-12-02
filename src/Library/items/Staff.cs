//staff en espaniol es Baston
namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Staff : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 33;
            }
        }
        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

    }
}