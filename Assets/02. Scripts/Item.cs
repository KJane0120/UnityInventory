using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    ATK,
    DEF,
    HP,
    Crit
}

public class Item
{
    [Header("Info")]
    public ItemType type;
    public string icon;

    [Header("Stat")]
    public int Value;
    //public int EquipATK;
    //public int EquipDEF;
    //public int EquipHP;
    //public int EquipCrit;


    //[Header("Equip")]
    //public GameObject equipPrefab;
    public Item(string icon, ItemType type, int value)
    {
        this.icon = icon;
        this.type = type;
        this.Value = value;
    }
}
