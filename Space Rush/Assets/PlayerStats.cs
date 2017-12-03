using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    [System.Serializable]
    public class CplayerStats
    {
        public
            float Health = 1000f;
    }

    public CplayerStats stats = new CplayerStats();
    

    private void Update()
    {
        DamagePlayer(1);
        //Debug.Log(stats.Health);
    }

    public void DamagePlayer(int damage)
    {
        stats.Health -= damage;
        if (stats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
            stats.Health = 100f;
            GameMaster.gm.RespawnPlayer();
        }
    }
    
	
}
