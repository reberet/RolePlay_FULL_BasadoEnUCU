using RoleplayGame.Characters;

public abstract class Hero : Character
{
    public int Victorypoints { get; private set; }
    protected Hero(string name) : base(name) { }
    public void AniadirVictoryPoints(int points) { if (points > 0) Victorypoints += points; }}//

public abstract class Enemy : Character
{ public int VictoryPointsRecibidos { get; }
    protected Enemy(string name, int recibidovp) : base(name) { VictoryPointsRecibidos = recibidovp; }}
