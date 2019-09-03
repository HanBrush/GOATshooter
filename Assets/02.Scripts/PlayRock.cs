using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRock : MonoBehaviour
{
    public AudioSource rockMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayMusic()
    {
        rockMusic = GetComponent<AudioSource>();
        rockMusic.Play();

    }

    public void StopMusic(){
        rockMusic = GetComponent<AudioSource>();
        rockMusic.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
