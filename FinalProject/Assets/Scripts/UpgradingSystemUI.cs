using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class UpgradingSystemUI : MonoBehaviour
{
    public Text text;
    public GameObject upgrade;
    Boolean inside;
    public GameObject iconRay;

    public void Start() {
        text = GetComponent<Text>();
    }
     public void Upgrade()
     {
        if (CounterCoinCopper.coinCounter >= 10)
        {
            Debug.Log("PURCHASED"); 
            text.text = "[Pay 150		to Upgrade the next Level]";
            iconRay.SetActive(true);
        }

        if (CounterCoinCopper.coinCounter != 10)
        {
            Debug.Log("NOT ENOUGH MONEY");
        }
     }
}
