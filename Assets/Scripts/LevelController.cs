using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



[Serializable]
public class LevelController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI click;
    [SerializeField]
    private Button ButtonLevel;
    [SerializeField]
    private String Nivel;

    public Button levelButton
    {
        get{ return ButtonLevel; }
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(Nivel);
    }

    public void LoadLevel(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }
}

