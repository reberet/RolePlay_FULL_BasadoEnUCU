using RoleplayGame.Items;

public class Lobizon : Enemy
{
    public Lobizon(string name) : base(name, 50)
    {
        this.Health = 90;
        this.AddItem(new Axe());
    }
}
