using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public AudioSource bEffect;
    // Start is called before the first frame update


void Start(){
    bEffect = GetComponent<AudioSource>();
}
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("FLOOR"))
        {
 

            bEffect.Play();
         
         
            
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
