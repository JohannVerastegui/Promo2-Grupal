using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class ClickCounter : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI textMeshProText;

    private int clicks = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            clicks++;
            textMeshProText.text = $"Clicks: {clicks}";
        }
    }

    private void OnGUI()
    {
    }
}
