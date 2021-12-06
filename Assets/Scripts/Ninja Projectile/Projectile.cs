﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Rigidbody2D rgb;

   
    [SerializeField]float speed;

//  public int damage ;
    
    float dir;

    



    public void shootProjectile(bool isNinjaFacingLeft)
    {
        if (isNinjaFacingLeft)
        {
            rgb.velocity = new Vector2(-speed , 0 );
            transform.eulerAngles = new Vector3 ( 0 ,0 ,90);
            dir = 90; 
        }
        if (!isNinjaFacingLeft)
        {
            rgb.velocity = new Vector2(speed , 0 );
            transform.eulerAngles = new Vector3 ( 0 ,0 , -90);
             dir = -90;
        }

        // Destroy(gameObject , 5f);
    }

    void OnCollisionEnter2D( Collision2D target)
    {
        if (target.gameObject.CompareTag("BouncyPlatform"))
        {
            dir += -90;
             
            transform.eulerAngles = new Vector3 ( 0 ,0 , dir);
        }
    }

   void OnEnable()
    {
        Destroy(gameObject,5f);
    }



}
