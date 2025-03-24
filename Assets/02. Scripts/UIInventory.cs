using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI haveNum;
    [SerializeField] private TextMeshProUGUI allNum;
    [SerializeField] private Button backBtn;
    [SerializeField] private UISlot[] slots;

    public List<UISlot> uISlots = new List<UISlot>();

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

    private void InitInventoryUI()
    {

    }
}
