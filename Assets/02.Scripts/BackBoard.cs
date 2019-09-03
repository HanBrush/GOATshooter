using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBoard : MonoBehaviour

{
    public AudioSource backBoard;

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("BALL")){
            backBoard = GetComponent<AudioSource>();
            backBoard.Play();
            


        }
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction *0.1f);
    }
    // Start is called before the first frame update

}
