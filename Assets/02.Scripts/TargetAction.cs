using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAction : MonoBehaviour
{
   GameObject rightHandController;

   Transform tr;

   Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
rightHandController = GameObject.Find("RightControllerAnchor");
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        
    }

    void Update(){

        if(OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)){

        tr.SetParent(rightHandController.transform,true);
        rb.isKinematic = true;
    }

    if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)){        
       tr.SetParent(null, true);
        rb.isKinematic = false;
       

    }

    // Update is called once per frame
}
}
