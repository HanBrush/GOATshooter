using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtoStart : MonoBehaviour
{
    GameObject backBall;
    Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
       startPosition = GameObject.FindGameObjectWithTag("BALL").GetComponent<Transform>();
       
    }


//  if (hit.collider.tag.Equals ("BALL")) {
//                     movingB = hit.collider.gameObject;
//                 }
//                 if (movingB != null) {
//                     GaugeChange ();
//                     MovingBall ();
    void OnTriggerEnter(Collider other) {
  

        if(other.tag.Equals("BALL"))
        {
            backBall = other.gameObject;
            // Debug.Log("sensor success");
            Destroy(backBall, 3.0f);

            // Destroy(backBall, 3.0f);
        }
        
    }

    // Update is called once per frame
   
}
