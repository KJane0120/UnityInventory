using System.Collections.Generic;

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
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void OnEquip(Item item)
    {
        //선택한 아이템이 이미 장착중이라면 해제
        if (IsEquip(item))
        {
            OnUnEquip(item);
        }
        //선택한 아이템이 장착중이 아니라면 장착
        else
        {
            if (item == UIManager.Instance.UIInventory.selectedItem)
            {
                switch (item.type)
                {
                    case ItemType.ATK:
                        ATK += item.Value;
                        break;
                    case ItemType.DEF:
                        DEF += item.Value;
                        break;
                    case ItemType.HP:
                        HP += item.Value;
                        break;
                    case ItemType.Crit:
                        Crit += item.Value;
                        break;
                }
                IsEquipped = true;
                EquipList.Add(item);
            }
        }
    }

    public bool IsEquip(Item item)
    {
        for (int i = 0; i < EquipList.Count; i++)
        {
            if (EquipList[i] == item) //Contains()를 활용하면 성능이 어떻게 되는지?
            {
                return true;
            }
        }
        return false;
    }

    public void OnUnEquip(Item item)
    {
        if (IsEquip(UIManager.Instance.UIInventory.selectedItem)) return; // 장착중이라면 반환

        if (item == UIManager.Instance.UIInventory.selectedItem)
        {
            switch (item.type)
            {
                case ItemType.ATK:
                    ATK -= item.Value;
                    break;
                case ItemType.DEF:
                    DEF -= item.Value;
                    break;
                case ItemType.HP:
                    HP -= item.Value;
                    break;
                case ItemType.Crit:
                    Crit -= item.Value;
                    break;
            }
            IsEquipped = false;
            EquipList.Remove(item);
        }
    }
}
