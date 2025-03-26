using UnityEngine;


/// <summary>
/// 아이템 타입을 구분합니다. 
/// </summary>
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
    
    /// <summary>
    /// 아이템 생성자입니다. 
    /// 아이템의 Image를 string으로 선언해 경로를 참조합니다. 
    /// </summary>
    /// <param name="icon"></param>
    /// <param name="type"></param>
    /// <param name="value"></param>
    public Item(string icon, ItemType type, int value)
    {
        this.icon = icon;
        this.type = type;
        this.Value = value;
    }
}
