﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Censor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("BALL"))
        {
            Destroy(other.gameObject,1.0f);
        }    
    }
}
