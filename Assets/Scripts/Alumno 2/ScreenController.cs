using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public static ScreenController instance;

    public WinScreen winScreen;
    public LoseScreen loseScreen;
    public CreditsScreen creditsScreen;
    public MenuScreen menuScreen;

    private void Awake() 
    { 
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            instance = this; 
        } 
    }

    public void ShowCreditsScreen()
    {
        creditsScreen.Show();
    }

    public void ShowWinScreen()
    {
        winScreen.Show();
    }

    public void ShowLoseScreen()
    {
        loseScreen.Show();
    }

    public void ShowMenuScreen()
    {
        menuScreen.Show();
    }

    public static ScreenController Instance => instance;
}