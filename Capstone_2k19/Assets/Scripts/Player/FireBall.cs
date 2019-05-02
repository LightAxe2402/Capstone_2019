﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float lifeTime = 10;

    void Update()
    {
        if(lifeTime == 0)
        {
            Destroy(gameObject);
        }
        else
        {
            lifeTime -= 1;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        else if (col.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }


}
