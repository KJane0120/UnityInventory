using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI haveNum;
    [SerializeField] private TextMeshProUGUI allNum;
    [SerializeField] private Button backBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void Back()
    {
        UIManager.Instance.UIInventory.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }
}
