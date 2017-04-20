using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCode : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    private int count = 0;
    bool chack = true;

    int frameCounter = 0;
    int countDirection = 1;

    // Update is called once per frame
    void Update()
    {

        //if (chack)
        //{
        //    if (count >= 99)
        //    {
        //        chack = false;
                
        //    }
        //    Debug.Log(count);
        //    count++;
        //}
        //else
        //{
        //    if (count <= 1)
        //        chack = true;
        //    Debug.Log(count);
        //    count--;
        //}

        if (frameCounter == 100)
        {
            countDirection = -1;
        }
        if (frameCounter == 0)
        {
            countDirection = 1;
        }
        frameCounter = frameCounter + countDirection;
        Debug.Log(frameCounter);
    }
}
