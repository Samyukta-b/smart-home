using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampOnOff : MonoBehaviour
{
    Light myLamp;

    void Start()
    {
        myLamp = GetComponent<Light>();        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            myLamp.enabled = !myLamp.enabled;
        }
    }
}
