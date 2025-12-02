namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType //public enum es un tipo de dato definido por el usuario que crea un conjunto de constantes con nombre accesibles desde cualquier parte del código
    {
        Magic = 1,
        Robes = 2,
        Bow =  3,
        Sword = 4,
        Staff = 5,

        Axe = 6,

        Armor = 7,
        Helmet = 8,

        SpellOne = 9,

        SpellBook = 10,

        

        
    
    
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Bow: return new Bow();
                case ItemType.Sword: return new Sword();
                case ItemType.Staff: return new Staff();
                case ItemType.Axe: return new Axe();
                case ItemType.Armor: return new Armor();
                case ItemType.Helmet: return new Helmet();
                
                
                

                
                


                default: return null;
            }
        }
    }
}