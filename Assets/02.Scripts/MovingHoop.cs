using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHoop : MonoBehaviour {
    float delta = -0.005f;

    // Transform originalPos;


    public static bool isMoving = false;
    // Start is called before the first frame update
    void Start () {

        // Transform originalPos = GetComponent<Transform>();       
       isMoving = false;

    }

    // Update is called once per frame
    void Update () {
        if (isMoving == true) {
            float newXPos = transform.position.x + delta;
            transform.position = new Vector3 (newXPos, transform.position.y, transform.position.z);
            if (transform.position.x <= 0) {
                delta *= -1.0f;
            } else if (transform.position.x >= 0.8) {
                delta *= -1.0f;
            }
        } 
        else if (isMoving == false) {
            transform.localPosition = new Vector3(0.4204445f, 1.458009f, 1.486761f);
        }
    }
}