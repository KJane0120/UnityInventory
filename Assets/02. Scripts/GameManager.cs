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

    public void SetData()
    {
        player = new Character("JaeM", 10, 35, 40, 100, 25, 20000, player.Inventory);
        UIManager.Instance.UIMainMenu.SettingInfo();
        UIManager.Instance.UIStatus.SettingInfo();
    }
}
