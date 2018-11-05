using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health_Manager : MonoBehaviour {

    public int playermaxhp;
    public int playercurrenthp;

	// Use this for initialization
	void Start () {

        playercurrenthp = playermaxhp;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(playercurrenthp <= 0)
        {
            gameObject.SetActive(false);
            //gamemanager.reload;
        }
		
	}

    public void HurtPlayer(int damageToGive)
    {

        playercurrenthp -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playercurrenthp = playermaxhp;
    }

}
