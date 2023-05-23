using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton 
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject manager = new GameObject("GameManager");
                    instance = manager.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    public float timer = 0f;

    public float GetTimer()
    {
        return timer;
    }

    public void IncreaseGameTimer(float deltaTime)
    {
        timer += deltaTime;
    }
}
