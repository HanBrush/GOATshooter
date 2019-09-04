using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    public GameObject hoop;
    public GameObject goalPost;
    public static int level = 1;

    // Start is called before the first frame update
    void Start () {
                if (level == 1) { 

                  
        }

        if (level == 2) {

            hoop.transform.localScale -= new Vector3(0.07f, 0.07f,0);

            hoop.transform.position = new Vector3 (hoop.transform.position.x, hoop.transform.position.y, hoop.transform.position.z + 0.065f);

            goalPost.transform.position = new Vector3 (goalPost.transform.position.x, goalPost.transform.position.y, goalPost.transform.position.z + 0.4f);

        }

        if(level==3){

           hoop.transform.localScale -= new Vector3(0.12f, 0.12f,0);

 hoop.transform.position = new Vector3 (hoop.transform.position.x, hoop.transform.position.y, hoop.transform.position.z + 0.096f);

            goalPost.transform.position = new Vector3 (goalPost.transform.position.x, goalPost.transform.position.y, goalPost.transform.position.z + 0.8f);


        }

    }

    

   

    // Update is called once per frame
    void Update () {

    }
}