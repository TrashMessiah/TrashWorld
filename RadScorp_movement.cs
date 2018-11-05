using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RadScorp_movement : MonoBehaviour {

    public float moveSpeed;

    private Rigidbody2D mrb;
    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

    public float waitTimeToReload;
    private bool reloading;
    private GameObject thePlayer;

	// Use this for initialization
	void Start () {

        //timeBetweenMoveCounter = timeBetweenMove;
        //timeToMoveCounter = timeToMove;
        mrb = GetComponent<Rigidbody2D>();
        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMoveCounter * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);
		
	}
	
	// Update is called once per frame 
	void Update () {

        if(moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            mrb.velocity = moveDirection;

            if(timeToMoveCounter < 0f)
            {
                moving = false;
                // timeBetweenMoveCounter = timeBetweenMove;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMoveCounter * 1.25f);
            }


        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            mrb.velocity = Vector2.zero;
            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                //timeToMoveCounter = timeToMove;
                timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);

                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }
        if(reloading)
        {
            waitTimeToReload -= Time.deltaTime;
            if(waitTimeToReload < 0)
            {


#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(index: Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
                thePlayer.SetActive(true);

            }
        }

	}

  
}
