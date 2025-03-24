using System;
using UnityEngine;


public enum ItemType
{
    ATK,
    DEF,
    HP,
    Crit
}

//[Serializable]
//public class ItemValue
//{
//    public ItemType type;
//    public int value;
//}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string itemName;
    //public string description;
    public ItemType type;
    public Sprite icon;

    [Header("Stat")]
    public int EquipATK;
    public int EquipDEF;
    public int EquipHP;
    public int EquipCrit;

    //[Header("Equip")]
    //public GameObject equipPrefab;
}
