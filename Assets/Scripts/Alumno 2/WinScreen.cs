using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : AbstractScreen
{
    public int winCount;
    public Button buttonCredits;
    public Text textWinCount;

    public override void Init()
    {
        ButtonObserver.RegisterButton(buttonCredits, ShowCreditsScreen);
    }

    public override void Show()
    {
        base.Show();
        winCount += 1;
        textWinCount.text = "Victorias: " + winCount;
    }

    private void ShowCreditsScreen()
    {
        Hide();
        ScreenController.Instance.ShowCreditsScreen();
    }
}