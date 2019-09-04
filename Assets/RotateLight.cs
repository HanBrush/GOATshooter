using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
float movingIndex = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAngle = transform.rotation.x + movingIndex;

        Quaternion lt = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        // Quaternion.rotation = new Quaternion(xAngle, transform.rotation.y, transform.rotation.z);

        if(xAngle >= 135.0f){
            movingIndex = -movingIndex;
        }

        if(xAngle <= 40.0f){
            movingIndex = -movingIndex;
        }
    }
}
