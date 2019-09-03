using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopSound : MonoBehaviour
{
    public AudioSource hoopSound;
    // Start is called before the first frame update
    void Start()
    {
        hoopSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other){
        
        if(other.gameObject.CompareTag("BALL")){
            hoopSound.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
