﻿using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI haveNum;
    [SerializeField] private TextMeshProUGUI allNum;
    [SerializeField] private Button backBtn;
    [SerializeField] private UISlot slot;
    [SerializeField] private Transform content;

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

    private void InitInventoryUI()
    {
        if (slot == null) return;

        //아이템이 있다면

        int count = 5;
        for (int i = 0; i < count; i++)
        {
            UISlot newSlot = Instantiate(slot.Prefab, content).GetComponent<UISlot>();
            UISlots.Add(newSlot);
        }
    }
}
