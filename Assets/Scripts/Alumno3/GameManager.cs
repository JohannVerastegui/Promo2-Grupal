using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour, ISubject
{

    private static GameManager instance;

    private List<IObserver> observers = new List<IObserver>();

    [SerializeField]
    private float timer;

    [SerializeField]
    private string sceneName;

    [SerializeField]
    private float maxtimer;

    public float MaxTimer { get { return maxtimer; } }

    private void Awake()
    {
        observers = new List<IObserver>();
        instance = this;
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=maxtimer)
        {
            SceneManager.LoadScene(sceneName);
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Execute(this);
        }
    }
}
