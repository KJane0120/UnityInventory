using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Item item;
    [SerializeField] private Image icon;
    [SerializeField] private GameObject equipCheck;
    [SerializeField] private Button equipifClick;

    private void Start()
    {
        Debug.Log("연결");
        equipifClick.onClick.AddListener(Equip);
    }

    private void Equip()
    {
        GameManager.Instance.player.OnEquip(this);

        if (GameManager.Instance.player.IsEquip(this))
        {
            equipCheck.SetActive(true);
        }
        else equipCheck.SetActive(false);
    }
  

    public void SetItem(Item data) // 슬롯에 아이템 데이터 추가
    {
        item = data;

        if (item != null)
        {
            Sprite loadedIcon = Resources.Load<Sprite>(item.icon);
            if (loadedIcon != null)
            {
                icon.sprite = loadedIcon;
                icon.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("아이콘 경로를 찾을 수 없습니다.");
                icon.gameObject.SetActive(false);
            }
        }
        else
        {
            icon.gameObject.SetActive(false);
        }
    }

    public void RefreshUI() //데이터를 UI에 표시
    {
        for (int i = 0; i < UIManager.Instance.UIInventory.UISlots.Count; i++)
        {
            UIManager.Instance.UIInventory.UISlots[i].SetItem(GameManager.Instance.player.Inventory[i]);
        }
    }
}
