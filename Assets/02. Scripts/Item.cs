using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemData data;

    public ItemType type { get {return data.type; } }
    public Sprite icon { get {return data.icon;} }

    //public ItemValue Value { get {return data.value;} }

    //public Item(Sprite icon, ItemType type, ItemValue value)
    //{
    //    this.icon = icon;
    //    this.type = type;
    //}
}
