using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public ParticleSystem[] sparks;
    public GameObject hoop;
    public GameObject backBoardBig;
public GameObject backBoardSmall;

    public Material darkRed;

    public Material material7;

    public Material white;

    public Material yellowLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Courtmode(){
        hoop.GetComponent<MeshRenderer>().material = darkRed;
        backBoardBig.GetComponent<MeshRenderer>().material = material7;
        backBoardSmall.GetComponent<MeshRenderer>().material = white;
        for(int i =0;i<3;i++)   {
                            sparks[i].Stop();
                        }

    }

    public void Rockmode(){
        hoop.GetComponent<MeshRenderer>().material = yellowLight;
                backBoardBig.GetComponent<MeshRenderer>().material = yellowLight;
                        backBoardSmall.GetComponent<MeshRenderer>().material = yellowLight;
                        for(int i =0;i<3;i++)   {
                            sparks[i].Play();
                        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
