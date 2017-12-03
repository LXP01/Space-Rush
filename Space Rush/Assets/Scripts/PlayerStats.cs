using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    [System.Serializable]
    public class playerStats
    {
        public
            float Health = 1000f;
    }

    public playerStats stats = new playerStats();
    

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
            KillPlayer.Kill(this);
        }
    }
    
	
}
