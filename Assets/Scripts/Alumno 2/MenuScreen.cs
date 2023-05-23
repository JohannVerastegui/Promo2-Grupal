using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : AbstractScreen
{
    public Button buttonWin;
    public Button buttonLose;
    
    public override void Init()
    {
        ButtonObserver.RegisterButton(buttonWin, ShowWinScreen);
        ButtonObserver.RegisterButton(buttonLose, ShowLoseScreen);
    }

    private void ShowWinScreen()
    {
        Hide();
        ScreenController.Instance.ShowWinScreen();
    }

    private void ShowLoseScreen()
    {
        Hide();
        ScreenController.Instance.ShowLoseScreen();
    }
}