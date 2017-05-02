using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin_Counter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public string coinStringTag;
    public string badCoinStringTag;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision  " + col.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == coinStringTag)
        {
            score++;
        }
        else if (other.tag == badCoinStringTag && score != 0)
        {
            score--;
        }
        Debug.Log("Trigger  " + score + "  " + other.gameObject.name);

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject);
    }    
}
