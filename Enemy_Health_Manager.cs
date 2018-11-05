using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health_Manager : MonoBehaviour {

    public int enemymaxhp;
    public int enemycurrenthp;

    // Use this for initialization
    void Start()
    {

        enemycurrenthp = enemymaxhp;

    }

    // Update is called once per frame
    void Update()
    {

        if (enemycurrenthp <= 0)
        {
            Destroy(gameObject);
            //gamemanager.reload;
        }

    }

    public void HurtEnemy(int damageToGive)
    {

        enemycurrenthp -= damageToGive;
    }

    public void SetMaxHealth()
    {
        enemycurrenthp = enemymaxhp;
    }
}
