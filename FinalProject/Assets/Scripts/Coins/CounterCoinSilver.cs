using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterCoinSilver : MonoBehaviour
{
    Text text;
    public static int coinCounter;

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinCounter.ToString();
    }
}
