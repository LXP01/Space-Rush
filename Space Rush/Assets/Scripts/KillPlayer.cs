using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public static void Kill(PlayerStats player)
    {
        Destroy(player.gameObject);
    }
	
}
