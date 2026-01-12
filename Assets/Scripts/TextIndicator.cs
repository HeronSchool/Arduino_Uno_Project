using UnityEngine;
using TMPro;

public class TextIndicator : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI textIndicator = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textIndicator.text = "0V";
    }

    // Update is called once per frame
    void Update()
    {
        textIndicator.text = string.Format("{0:f2}",(Connect_Arduino.Instance.val/1023)*5) + "V";
    }
}
