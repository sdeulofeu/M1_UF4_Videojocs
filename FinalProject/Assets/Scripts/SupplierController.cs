using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class SupplierController : MonoBehaviour
{
    public GameObject coin;
    public GameObject coinPos;
    public int coinRespawnTime;
    public Boolean available = true;
    public GameObject panel;
    public FirstPersonAIO player;
   
    void Start()
    {
        if (available)
        { 
            InvokeRepeating("Spawn", 5, 2);
        }
       
    }
    void Spawn()
    {
        Instantiate(coin, coinPos.transform.position, coin.transform.rotation);
    }

    
    void OnTriggerStay(Collider other)
    {
        if (panel.activeInHierarchy && other.CompareTag("player") && Input.GetKeyDown(KeyCode.F))
        {
            panel.SetActive(false); 
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        else if (!panel.activeInHierarchy && other.CompareTag("player") && Input.GetKeyDown(KeyCode.F))
        {
            panel.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }


    }    
}
