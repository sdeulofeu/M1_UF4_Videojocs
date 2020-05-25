using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class CoinBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
   public void Update() => transform.Rotate(0f, 0f, 1f);

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
}
