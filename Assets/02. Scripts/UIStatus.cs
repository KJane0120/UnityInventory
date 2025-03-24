using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI critText;
    [SerializeField] private Button backBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void Back()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }
    
}
