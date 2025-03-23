using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goldText;
    private int gold; 

    private void Start()
    {
        gold = 20000;
        goldText.text = string.Format("{0:N0}", gold);
    }

}
