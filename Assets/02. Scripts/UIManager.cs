using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    public Character character;

    public GameObject UIMainMenu { get { return GetComponentInChildren<UIMainMenu>(true).gameObject; } }
    public GameObject UIStatus {  get { return GetComponentInChildren<UIStatus>(true).gameObject; } }
    public GameObject UIInventory { get { return GetComponentInChildren<UIInventory>(true).gameObject; } }

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
