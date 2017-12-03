using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;

    

    void Start()
    {
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 2;

    public void RespawnPlayer()
    {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public static void KillPlayer(PlayerStats player)
    {
        Destroy(player.gameObject);
        gm.RespawnPlayer();
    }

}