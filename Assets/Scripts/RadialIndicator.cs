using UnityEngine;
using UnityEngine.UI;

public class RadialIndicator : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Image radialIndicatorUI = null;



    void Start()
    {
    }

    void Update()
    {
        radialIndicatorUI.fillAmount = Connect_Arduino.Instance.val/1023;
    }
}
