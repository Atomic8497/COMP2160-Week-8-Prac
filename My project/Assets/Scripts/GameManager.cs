using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static private GameManager instance; //Singleton Object
    static public GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("There is no GameManager instance in the scene.");
            }
            return instance;
        }
    }

    private int currentScore = 0;
    public int CurrentScore
    {
        get
        {
            return currentScore;
        }
    }

    [Range(0, 100)] [SerializeField] private int points = 1; //Points

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject); //If there is already a UIManager in the scene
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Score()
    {
        currentScore += points;
    }
}
