using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    public Item item;
    public Image icon;
    public Image equipCheck;
    public bool equipped { get { return GameManager.Instance.player.IsEquipped; } }


    public void SetItem() // 슬롯에 아이템 데이터 추가, 여기에 player.additem함수 
    {
        
    }

    public void RefreshUI() //데이터를 UI에 표시
    {

    }
}
