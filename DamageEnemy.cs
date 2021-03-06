﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageEnemy : MonoBehaviour
{
    public int damageToGive;
    public GameObject bloodBurst;
    public Transform hitPoint;
    public GameObject damageNumber;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            // Destroy(other.gameObject); 
            other.gameObject.GetComponent<Enemy_Health_Manager>().HurtEnemy(damageToGive);
            Instantiate(bloodBurst, hitPoint.position, hitPoint.rotation);
            var clone = (GameObject)Instantiate(damageNumber, hitPoint.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = damageToGive;
        }

    }
}
