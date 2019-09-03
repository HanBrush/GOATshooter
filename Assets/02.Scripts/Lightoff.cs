using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightoff : MonoBehaviour
{
    public void TurnOffLight(){
        Light light = GetComponent<Light>();
        light.enabled = false;
    }

    public void TurnOnLight(){
                Light light = GetComponent<Light>();
        light.enabled = true;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
