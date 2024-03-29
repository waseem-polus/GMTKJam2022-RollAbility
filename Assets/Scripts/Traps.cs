using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    private GameObject player;
    private DicePointManager respawnManager;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        respawnManager = GameObject.FindGameObjectsWithTag("RespawnManager")[0].GetComponent<DicePointManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Debug.Log("Player Died! :(");
            respawnManager.RespawnPlayer();
        }
    }
}
