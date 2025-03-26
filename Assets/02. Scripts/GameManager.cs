using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public Character player {  get; private set; }

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
        SetData();
    }

    /// <summary>
    /// 실행 처음에 기본적인 데이터를 설정합니다.
    /// </summary>
    public void SetData()
    {
        player = new Character("JaeM", 10, 35, 40, 100, 25, 20000);

        Item Axe = new Item("AxeT1", ItemType.ATK, 10);
        Item Bow = new Item("BowT1", ItemType.DEF, 10);
        Item Shield = new Item("ShieldLargeT1", ItemType.HP, 50);
        Item Gem = new Item("GemRed", ItemType.Crit, 5);

        player.AddItem(Axe);
        player.AddItem(Bow);
        player.AddItem(Shield);
        player.AddItem(Gem);

        UIManager.Instance.UIMainMenu.ReSourceInfo();
        UIManager.Instance.UIStatus.PlayerStatInfo();
        UIManager.Instance.UIInventory.InventoryInfo();
    }
}
