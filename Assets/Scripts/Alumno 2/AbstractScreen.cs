using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractScreen : MonoBehaviour, IScreen
{
    public abstract void Init();

    public void Awake()
    {
        Init();
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }
}
