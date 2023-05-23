using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ButtonObserver
{
    public static List<Button> buttonList;

    public static  void RegisterButton(Button button, Action onButtonClick)
    {
        if(buttonList == null)
        {
            buttonList = new List<Button>();
        }

        button.onClick.AddListener(() => onButtonClick());
        buttonList.Add(button);
    }
}