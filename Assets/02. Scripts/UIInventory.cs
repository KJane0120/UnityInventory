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
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }

    public void InventoryInfo()
    {
        haveNum.text = string.Format("{0:N0}", GameManager.Instance.player.Inventory.Count);
    }

    public void InitInventoryUI() //슬롯 생성해주는 함수
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
