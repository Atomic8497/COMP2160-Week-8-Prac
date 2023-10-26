using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour //Coin prefab outdated causing the objects in the scene not to work
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

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            gameManager.Score();
            Destroy(gameObject);
        }
    }
}
