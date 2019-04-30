﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeHitBox : MonoBehaviour
{
    public bool inRange = false;
    private void OnTriggerEnter(Collider col)
    {
        inRange = true;
        if (col.gameObject.tag == "Enemy") { Debug.Log("Enemy Entered"); }        
    }

    void OnTriggerStay(Collider col)
    {
        GameObject player = GameObject.Find("Player");
        PlayerCombatController script = player.GetComponent<PlayerCombatController>();

        if (col.gameObject.tag == "Enemy" && script.Attacking == true)
        {
            Destroy(col.gameObject);            
        }
    }

    private void OnTriggerExit(Collider col)
    {
        inRange = false;
        if (col.gameObject.tag == "Enemy") { Debug.Log("Enemy Exited"); }
    }
}
