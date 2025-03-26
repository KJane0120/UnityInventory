using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Stat")]
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI critText;

    [Header("Button")]
    [SerializeField] private Button backBtn;

    /// <summary>
    /// 뒤로가기 버튼 클릭시 호출할 함수를 연결합니다. 
    /// </summary>
    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    private void LateUpdate()
    {
        PlayerStatInfo();
    }

    /// <summary>
    /// 스탯들을 보간문자열로 UI에 표시합니다. 
    /// </summary>
    public void PlayerStatInfo()
    {
        atkText.text = string.Format("{0:N0}", GameManager.Instance.player.ATK);
        defText.text = string.Format("{0:N0}", GameManager.Instance.player.DEF);
        hpText.text = string.Format("{0:N0}", GameManager.Instance.player.HP);
        critText.text = string.Format("{0:N0}", GameManager.Instance.player.Crit);
        
    }

    /// <summary>
    /// 뒤로가기 버튼 클릭시 호출되는 함수입니다. 
    /// </summary>
    private void Back()
    {
        this.gameObject.SetActive(false);
        UIManager.Instance.UIMainMenu.PopupBtn.SetActive(true);
    }
    
}
