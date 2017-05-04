using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin_Counter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public Text resultText;
    public string winText;
    public string loseText;

    public string coinStringTag;
    public string badCoinStringTag;

    public GameObject Menu;
    public modzraoba move;
    public Rigidbody myBody;

    int targetScore;

    void Start()
    {
        targetScore = GameObject.FindGameObjectsWithTag(coinStringTag).Length;

        Menu.SetActive(false);
    }

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
        else if (other.tag == badCoinStringTag)
        {
            GameOver(false);

        }
        Debug.Log("Trigger  " + score + "  " + other.gameObject.name);

        scoreText.text = "Score: " + score;
        Destroy(other.gameObject);

        if (targetScore == score)
        {
            GameOver(true);
        }
    }

    void GameOver(bool didWin)
    {

        Menu.SetActive(true);
        move.enabled = false;
        myBody.isKinematic = true;

        if (didWin)
        {
            resultText.text = winText;
        }

        else
        {
            resultText.text = loseText;
        }
    }


}
