using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetect : MonoBehaviour
{
    public Text scoreBoard;

    

    public static int score;

    public GameObject openRockmode;

    public GameObject unLock;
    
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
        if(score >= 10){
            openRockmode.SetActive(true);
            unLock.SetActive(false);
        }
    }
}
