using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHoop : MonoBehaviour {
    float delta = -0.005f;

    public Transform originalPos;

    public static bool isMoving = false;
    // Start is called before the first frame update
    void Start () {
       

    }

    // Update is called once per frame
    void Update () {
        if (isMoving) {
            float newXPos = transform.position.x + delta;
            transform.position = new Vector3 (newXPos, transform.position.y, transform.position.z);
            if (transform.position.x <= 0) {
                delta *= -1.0f;
            } else if (transform.position.x >= 0.8) {
                delta *= -1.0f;
            }
        } 
        else if (isMoving == false) {
            transform.position = originalPos.position;
        }
    }
}