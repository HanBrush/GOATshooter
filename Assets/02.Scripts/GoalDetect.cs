using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetect : MonoBehaviour {
    public Text scoreBoard;

    public static int score;

    public GameObject openRockmode;

    public GameObject unLock;

    public GameObject scoreOverten;

    public AudioSource crowdapplause;

    // Start is called before the first frame update
    void Start () {
        score = 0;
    }

    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("BALL")) {
            Debug.Log ("GOAL");
            score += 2;

            scoreBoard.text = "SCORE:  " + score.ToString ();

        }

        if (score == 10) {
            openRockmode.SetActive (true);
            unLock.SetActive (false);

            scoreOverten.SetActive (true);
            crowdapplause = GetComponent<AudioSource> ();
            crowdapplause.Play ();

        }

    }

    public void DestroyScoreOverTen () {

        scoreOverten.SetActive (false);
    }

    // Update is called once per frame
    void Update () { }
}