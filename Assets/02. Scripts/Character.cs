using UnityEngine;

public class Character : MonoBehaviour
{
    public string ID;
    public int Level;
    //public string Tier;
    //public int Gold;
    public int ATK;
    public int DEF;
    public int HP;
    public int Crit;

    public Character(string id, int lv, int atk, int def, int hp, int crit) //생성자
    {
        this.ID = id;
        this.Level = lv;
        this.ATK = atk;
        this.DEF = def;
        this.HP = hp;
        this.Crit = crit;
    }

}
