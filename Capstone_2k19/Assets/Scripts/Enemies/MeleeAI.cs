﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MeleeAI : BattleAI
{
    [Header("Attacker State Variables")]
    [SerializeField] private float clawDamage = 10f;

    #region Attack Functions
    public void BeginSwipe() { anim.SetTrigger("ClawSwipe"); }

    public void ClawSwipe()
    {
        Debug.Log(name + " performed a claw swipe for " + clawDamage + " damage");

        // Dealing Damage
        if (PlayerInAttackRange())
            target.TakeDamage(clawDamage);

        // Attack Finished, reset AI state
        attackInProgress = false;
    }
    #endregion   
}
