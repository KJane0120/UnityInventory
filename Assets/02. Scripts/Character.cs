using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int HP { get; private set; }
    public int Crit { get; private set; }

    public Item item;
    public List<Item> Inventory;
    public List<Item> EquipList;
    public bool IsEquipped;
    //public GameObject equipCheck { get { return UIManager.Instance.UIInventory.slot.equipCheck; } }


    public Character(string id, int lv, int atk, int def, int hp, int crit, int gold) //생성자
    {
        this.ID = id;
        this.Level = lv;
        this.ATK = atk;
        this.DEF = def;
        this.HP = hp;
        this.Crit = crit;
        this.Gold = gold;
        this.Inventory = new List<Item>();
        this.EquipList = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void OnEquip(UISlot slot)
    {
        //선택한 아이템이 이미 장착중이라면 해제
        if (IsEquip(slot))
        {
            UnEquip(slot);
        }
        //선택한 아이템이 장착중이 아니라면 장착
        else
        {
            switch (slot.item.type)
            {
                case ItemType.ATK:
                    ATK += slot.item.Value;
                    break;
                case ItemType.DEF:
                    DEF += slot.item.Value;
                    break;
                case ItemType.HP:
                    HP += slot.item.Value;
                    break;
                case ItemType.Crit:
                    Crit += slot.item.Value;
                    break;
            }
            IsEquipped = true;
            EquipList.Add(slot.item);
        }
    }

    public bool IsEquip(UISlot slot)
    {
        for (int i = 0; i < EquipList.Count; i++)
        {
            if (EquipList[i] == slot.item) //Contains()를 활용하면 성능이 어떻게 되는지?
            {
                return true;
            }
        }
        return false;
    }

    //public void OnUnEquip(Item item)
    //{
    //    if (IsEquip(item)) return; // 장착중이라면 반환

    //    switch (item.type)
    //    {
    //        case ItemType.ATK:
    //            ATK -= item.Value;
    //            break;
    //        case ItemType.DEF:
    //            DEF -= item.Value;
    //            break;
    //        case ItemType.HP:
    //            HP -= item.Value;
    //            break;
    //        case ItemType.Crit:
    //            Crit -= item.Value;
    //            break;
    //    }
    //    IsEquipped = false;
    //    equipCheck.gameObject.SetActive(false);
    //    EquipList.Remove(item);
    //}

    public void UnEquip(UISlot slot)
    {
        switch (slot.item.type)
        {
            case ItemType.ATK:
                ATK -= slot.item.Value;
                break;
            case ItemType.DEF:
                DEF -= slot.item.Value;
                break;
            case ItemType.HP:
                HP -= slot.item.Value;
                break;
            case ItemType.Crit:
                Crit -= slot.item.Value;
                break;
        }
        IsEquipped = false;
        EquipList.Remove(slot.item);
    }
}
