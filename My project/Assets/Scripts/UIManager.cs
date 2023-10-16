using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    static private UIManager instance; //Singleton Object
    static public UIManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("There is no UIManager in the scene.");
            }
            return instance;
        }
    }
    public GameManager gameManager; //Game Manager
    public TextMeshProUGUI currentScoreCounter; //Current Score Counter

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

    // Update is called once per frame
    void Update()
    {
        int currentScore = gameManager.CurrentScore;
        currentScoreCounter.text = string.Format("Current Score: {0}", currentScore); //Update current score
    }
}
