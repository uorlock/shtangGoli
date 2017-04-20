using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BtuGameDev3 : MonoBehaviour
{

    public int health;
   
    // Use this for initialization
    void DamagePlayer(int damage)
    {
        health -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        DamagePlayer(1);
        if (health <= 0)
        {
            Destroy(gameObject, 5.5f);

            health = 0;
            //Debug.Log("This Player Has Dead!!! Health: " + health);
        }
        
    }
}
