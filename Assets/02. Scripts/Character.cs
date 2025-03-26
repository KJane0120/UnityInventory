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
        this.EquipList = new List<Item>();
    }

    /// <summary>
    /// 인벤토리 리스트에 아이템을 추가합니다. 
    /// </summary>
    /// <param name="item"></param>
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    /// <summary>
    /// 아이템을 선택했을 때 호출되는 함수입니다. 
    /// 이미 장착중이면 해제, 장착중이 아니면 장착을 합니다. 
    /// 장비 스탯을 캐릭터 스탯에 반영합니다. 
    /// </summary>
    /// <param name="slot"></param>
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

    /// <summary>
    /// EquipList에 있는지 여부로 장착중인지를 검사합니다. 
    /// </summary>
    /// <param name="slot"></param>
    /// <returns></returns>
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

    /// <summary>
    /// 이미 장착중일 때 호출되는 함수입니다. 
    /// 장비 스탯을 캐릭터 스탯에 반영합니다. 
    /// </summary>
    /// <param name="slot"></param>
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
