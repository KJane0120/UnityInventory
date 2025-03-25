using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goldText;
    [SerializeField] private TextMeshProUGUI idText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI tierText;
    [SerializeField] private GameObject popupBtn;
    public GameObject PopupBtn { get { return popupBtn; } }
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;
    [SerializeField] private Slider lvBar;
    private int curValue;
    private int maxValue;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        curValue = 80;
        maxValue = 100;
    }

    private void Update()
    {
        lvBar.value = GetPercentage();
    }

    public float GetPercentage()
    {
        float temp = (float)curValue / maxValue;
        return temp;
    }
    public void ReSourceInfo()
    {
        goldText.text = string.Format("{0:N0}", GameManager.Instance.player.Gold);
    }

    public void OpenMainMenu() //처음 시작 시 
    {
        UIManager.Instance.UIMainMenu.gameObject.SetActive(true);
    }

    public void OpenStatus() //Status 버튼을 눌렀을 때 실행
    {
        popupBtn.SetActive(false);
        UIManager.Instance.UIStatus.gameObject.SetActive(true);
    }

    public void OpenInventory() //Inventory 버튼을 눌렀을 때 실행
    {
        popupBtn.SetActive(false);
        UIManager.Instance.UIInventory.gameObject.SetActive(true);
    }
}
