using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{ 
public GameObject _Object; // Attach your GameObject you'd like to active/deactive in the inspector
 
        void Start()
        {
            Time.timeScale = 1f;
         }
        void Update()
        {
        //Code below is if you'd like to activate/deactivate the whole GameObject || DELETE IT IF YOU PREFER CODE BELOW
            if (_Object.activeInHierarchy && Input.GetKeyDown(KeyCode.I)) //Check if GO is active and if pressed key i
            {
                _Object.SetActive(false); //If so, then deactivate it
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1f;
            }
            else if (!_Object.activeInHierarchy && Input.GetKeyDown(KeyCode.I)) //Check if GO is deactivated and if pressed key i
            {
                _Object.SetActive(true);//If so, then activate it
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;
            }
    }
}