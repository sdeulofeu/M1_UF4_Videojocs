using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player : MonoBehaviour
{
    public static Boolean hasPlayer;
    public GameObject inv;

    void Start()
    {
        CounterCoin.coinCounter = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gold"))
        {
            Destroy(other.gameObject);
            CounterCoin.coinCounter += 1;
        }
        if (other.CompareTag("silver"))
        {
            Destroy(other.gameObject);
            Debug.Log("Has tocat una silver coin");
            CounterCoinSilver.coinCounter += 1;
        }
        if (other.CompareTag("copper"))
        {
            Destroy(other.gameObject);
            CounterCoinCopper.coinCounter += 1;
        } 
        

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Showing inve");
            inv.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Showing inve");
            inv.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }


    }



}
