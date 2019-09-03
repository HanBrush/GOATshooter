using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDisplay : MonoBehaviour
{

    public GameObject displayLock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DisplayLock()
    {
        displayLock.SetActive(true);
        new WaitForSeconds(2.0f);
        displayLock.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
