using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetect : MonoBehaviour
{
    public Text scoreBoard;

    

    int score;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("BALL")){
            Debug.Log("GOAL");
            score += 2;

            scoreBoard.text = "SCORE:  " + score.ToString();

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
