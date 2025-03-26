using UnityEngine;

/// <summary>
/// UIMainMenu, UIStatus, UIInventory를 연결하는 싱글톤 클래스입니다. 
/// </summary>
public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    public Character character;

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;
    public UIMainMenu UIMainMenu { get { return uiMainMenu; } }
    public UIStatus UIStatus {  get { return uiStatus; } }
    public UIInventory UIInventory { get { return uiInventory; } }

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
