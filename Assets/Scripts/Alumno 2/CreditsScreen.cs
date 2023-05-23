using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsScreen : AbstractScreen
{
    public int creditsCount;
    public Button buttonMenu;
    public List<string> groupMembers;
    public Text textCreditsCount;
    public Text textCreditsName;
    private Coroutine creditsSequence;

    public override void Init()
    {
        ButtonObserver.RegisterButton(buttonMenu, ShowMenuScreen);
    }

    public override void Show()
    {
        base.Show();
        creditsCount += 1;
        textCreditsCount.text = "Créditos: " + creditsCount;
        ShowCreditsSequence();
    }

    public override void Hide()
    {
        base.Hide();

        if(creditsSequence != null)
        {
            StopCoroutine(creditsSequence);
        }
    }

    private void ShowCreditsSequence()
    {
        creditsSequence = StartCoroutine(ExecuteCreditsSequence());
    }

    private IEnumerator ExecuteCreditsSequence()
    {
        foreach(string member in groupMembers)
        {
            textCreditsName.text = member;
            yield return new WaitForSeconds(1);
        }
    }

    private void ShowMenuScreen()
    {
        Hide();
        ScreenController.Instance.ShowMenuScreen();
    }
}