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
    [SerializeField] private GameObject popupBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void Back()
    {
        UIManager.Instance.UIStatus.SetActive(false);
        popupBtn.SetActive(true);
    }
    
}
