using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI haveNum;
    [SerializeField] private Button backBtn;
    public UISlot slot;
    [SerializeField] private Transform content;

    public Item item { get { return GameManager.Instance.player.item; } }

    public List<UISlot> UISlots = new List<UISlot>();

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
        InitInventoryUI();
    }

    private void Back()
    {
        this.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }

    /// <summary>
    /// 인벤토리에 추가된 아이템의 개수를 보간문자열로 UI에 표시합니다. 
    /// </summary>
    public void InventoryInfo()
    {
        haveNum.text = string.Format("{0:N0}", GameManager.Instance.player.Inventory.Count);
    }

    /// <summary>
    /// 인벤토리 리스트의 길이만큼 슬롯의 개수를 생성합니다. 
    /// </summary>
    public void InitInventoryUI()
    {
        if (slot == null) return;

        for (int i = 0; i < GameManager.Instance.player.Inventory.Count; i++)
        {
            UISlot newSlot = Instantiate(slot, content);
            UISlots.Add(newSlot);
        }
        slot.RefreshUI();
    }
}
