using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    private GameManager gameManager; // Game Manager

    void Awake()
    {
        gameManager = (GameManager) FindObjectOfType(typeof(GameManager)); // set game manager
        if(!gameManager)
        {
            Debug.LogError("There is no game manager in the scene");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colliding");
        if(collision.gameObject.tag == "Player"){
            Debug.Log("Hits");
            gameManager.Score();
            Destroy(gameObject);
        }
    }
}
