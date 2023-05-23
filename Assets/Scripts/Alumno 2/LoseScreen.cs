using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScreen : AbstractScreen
{
    public int loseCount;
    public Button buttonMenu;
    public Text textLoseCount;
    
    public override void Init()
    {
        ButtonObserver.RegisterButton(buttonMenu, ShowMenuScreen);
    }

    public override void Show()
    {
        base.Show();
        loseCount += 1;
        textLoseCount.text = "Derrotas: " + loseCount;
    }

    private void ShowMenuScreen()
    {
        Hide();
        ScreenController.Instance.ShowMenuScreen();
    }
}