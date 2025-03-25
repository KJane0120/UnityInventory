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
    private void LateUpdate()
    {
        PlayerStatInfo();
    }

    public void PlayerStatInfo()
    {
        atkText.text = string.Format("{0:N0}", GameManager.Instance.player.ATK);
        defText.text = string.Format("{0:N0}", GameManager.Instance.player.DEF);
        hpText.text = string.Format("{0:N0}", GameManager.Instance.player.HP);
        critText.text = string.Format("{0:N0}", GameManager.Instance.player.Crit);
        
    }
    private void Back()
    {
        UIManager.Instance.UIStatus.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }
    
}
