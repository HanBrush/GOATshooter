using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
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
            for(int i = 0; i<6 ; i++){
                Collider[] colls = Physics.OverlapSphere(spawnPoints[i].position,0.15f,1<<8);
                if(colls.Length == 0){
                    Instantiate(basketball, spawnPoints[i].position, Quaternion.identity);
                }
            }
            

        }
    }

       
    }

//     void Spawn(){
// //         int spawnPointIndex = Random.Range(0, spawnPoints.Length);

// //         Instantiate(basketball, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
// //   }

//     // Update is called once per frame

// }

