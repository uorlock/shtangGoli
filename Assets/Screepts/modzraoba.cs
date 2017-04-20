using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modzraoba : MonoBehaviour {

    Vector3 deltaPos;
    //public Transform player;
    public Rigidbody playerBody;
    public float maxSpeed;

	void Start () {
        deltaPos = Vector3.zero;
        	
	}
	
	//kadrebis update
	void Update () {


        //Debug.Log(Input.GetKey(KeyCode.DownArrow));
        deltaPos.x = Input.GetAxis("Horizontal");
        deltaPos.z = Input.GetAxis("Vertical");

        //player.position += deltaPos;
        

	}

    //fizikis update
    void FixedUpdate()
    {
        //playerBody.position += deltaPos;

        playerBody.AddForce(deltaPos*maxSpeed);
    }



}
