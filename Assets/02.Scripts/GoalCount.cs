using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalCount : MonoBehaviour{
    
    Rigidbody rb;
    public float speed;
    int count=0;
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        string v = countText.text="Count:" + count;
    }
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("BALL"))
        {
           
            count = count + 1;
            countText.text = "Count " + count;           
        }       
    }
}
