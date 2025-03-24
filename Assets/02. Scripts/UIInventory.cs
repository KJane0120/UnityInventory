using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI haveNum;
    [SerializeField] private TextMeshProUGUI allNum;
    [SerializeField] private Button backBtn;
    [SerializeField] private GameObject popupBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void Back()
    {
        UIManager.Instance.UIInventory.SetActive(false);
        popupBtn.SetActive(true);
    }
}
