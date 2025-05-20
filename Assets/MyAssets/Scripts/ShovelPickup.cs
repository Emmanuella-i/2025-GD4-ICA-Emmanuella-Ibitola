using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class ShovelPickup : MonoBehaviour
{
    public GameObject task2;
    public GameObject task3;
    public GameObject triggerbox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            task2.SetActive(false);
            task3.SetActive(true);
            triggerbox.SetActive(true);

        }
    }
}
