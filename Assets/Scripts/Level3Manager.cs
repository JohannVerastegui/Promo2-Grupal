using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level3Manager : MonoBehaviour
{
    public static Level3Manager instance;
    [SerializeField] public int bulletsLeft;
    [SerializeField] TextMeshProUGUI bulletsText;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateBulletText();
    }

    public void UpdateBulletText()
    {
        bulletsText.text = "Bullets: " + bulletsLeft.ToString();
        if (bulletsLeft <= 0)
        {
            FindObjectOfType<LevelController>().LoadLevel("Victory");
        }
    }
}
