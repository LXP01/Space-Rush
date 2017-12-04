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

    public GameObject Player;
    public Transform spawnPoint;
    public int spawnDelay = 2;
    public Transform Shot;
    public void RespawnPlayer()
    {
        Instantiate(Player, spawnPoint.position, spawnPoint.rotation);
    }

    public static void KillPlayer(PlayerStats player)
    {
        DestroyObject(player.gameObject);
        gm.RespawnPlayer();
    }

    


}