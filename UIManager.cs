using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text HPtext;
    public Player_Health_Manager playerHealth;

    private static bool UIExists;


    // Use this for initialization
    void Start () {
        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {

        healthBar.maxValue = playerHealth.playermaxhp;
        healthBar.value = playerHealth.playercurrenthp;
        HPtext.text = "HP: " + playerHealth.playercurrenthp+ "/" + playerHealth.playermaxhp;
		
	}
}
