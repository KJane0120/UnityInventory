using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    public Character character;

    [SerializeField] private GameObject uiMainMenu;
    [SerializeField] private GameObject uiStatus;
    [SerializeField] private GameObject uiInventory;
    public GameObject UIMainMenu { get { return uiMainMenu; } }
    public GameObject UIStatus {  get { return uiStatus; } }
    public GameObject UIInventory { get { return uiInventory; } }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Start()
    {
        UIMainMenu.GetComponent<UIMainMenu>().OpenMainMenu();
    }

}
