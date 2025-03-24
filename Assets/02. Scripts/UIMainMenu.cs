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
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;
    [SerializeField] private Slider lvBar;

    private int gold; 

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);

        gold = 20000;
        goldText.text = string.Format("{0:N0}", gold);
    }

    public void OpenMainMenu() //처음 시작 시 
    {
        UIManager.Instance.UIMainMenu.SetActive(true);
    }

    public void OpenStatus() //Status 버튼을 눌렀을 때 실행
    {
        popupBtn.SetActive(false);
        UIManager.Instance.UIStatus.SetActive(true);
    }

    public void OpenInventory() //Inventory 버튼을 눌렀을 때 실행
    {
        popupBtn.SetActive(false);
        UIManager.Instance.UIInventory.SetActive(true);
    }
}
