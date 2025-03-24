[System.Serializable]
public class Character
{
    public string ID {  get; private set; }
    public int Level { get; private set; }
    //public string Tier;
    public int Gold {  get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int HP { get; private set; }
    public int Crit { get; private set; }


    public Character(string id, int lv, int atk, int def, int hp, int crit, int gold) //생성자
    {
        this.ID = id;
        this.Level = lv;
        this.ATK = atk;
        this.DEF = def;
        this.HP = hp;
        this.Crit = crit;
        this.Gold = gold;
    }
}
