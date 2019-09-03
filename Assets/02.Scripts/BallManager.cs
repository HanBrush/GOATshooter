using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public float spawnTime = 2.0f;
    public Transform[] spawnPoints;

    public GameObject basketball;

    GameObject[] balls;





    // Start is called before the first frame update

    void Start()
    {
        
       
        // balls = GameObject.FindGameObjectsWithTag("BALL");
        // InvokeRepeating("Spawn",spawnTime,spawnTime);

         

        
      
    }


    void Update(){

    balls = GameObject.FindGameObjectsWithTag("BALL");
        if(balls.Length < 6) {
            Create();

        }
    }

    void Create(){
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(basketball, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }

       
    }

//     void Spawn(){
// //         int spawnPointIndex = Random.Range(0, spawnPoints.Length);

// //         Instantiate(basketball, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
// //   }

//     // Update is called once per frame

// }

