using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugePosition : MonoBehaviour
{
    Transform gauge_tr;

    GameObject rightHandController;


    // Start is called before the first frame update
    void Start()
    {
        gauge_tr = GetComponent<Transform>();
        rightHandController = GameObject.Find("RightHandAnchor");
    }

    // Update is called once per frame
    void Update()
    {
        gauge_tr.position = rightHandController.transform.position;
    }
}
