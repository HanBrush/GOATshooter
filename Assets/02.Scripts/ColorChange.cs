using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public ParticleSystem[] sparks;
    public GameObject hoop;
    public GameObject backBoardBig;
    public GameObject backBoardSmall;

    public Material darkRed;

    public Material material7;

    public Material white;

    public Material yellowLight;

    public ParticleSystem[] flames;

    public GameObject lighting;

  

   

    // public GameObject[] neon;
    // Start is called before the first frame update
    void Start () {


    }

    public void Courtmode () {
        //불켜기&끄기
        lighting.SetActive(true);
        // 농구골대 material 바꾸기
        hoop.GetComponent<MeshRenderer> ().material = darkRed;
        backBoardBig.GetComponent<MeshRenderer> ().material = material7;
        backBoardSmall.GetComponent<MeshRenderer> ().material = white;

        //스파크 튀기기
        for (int i = 0; i < 5; i++) {
            sparks[i].Stop ();
        }

        //불꽃 나오기
        for (int i = 0; i < 2; i++) {
            flames[i].Stop ();
        }

        //농구골대 움직임
        MovingHoop.isMoving = false;
        

        //네온사인
        // for(int neon_i = 0; neon_i<4; neon_i ++){
        // neon[neon_i].SetActive(false);}

    }

    public void Rockmode () {
lighting.SetActive(false);

        hoop.GetComponent<MeshRenderer> ().material = yellowLight;
        backBoardBig.GetComponent<MeshRenderer> ().material = yellowLight;
        backBoardSmall.GetComponent<MeshRenderer> ().material = yellowLight;
        for (int i = 0; i < 5; i++) {
            sparks[i].Play ();}

            for (int i = 0; i < 2; i++) {
                flames[i].Play ();
            }
            MovingHoop.isMoving = true;

        //             for(int neon_i = 0; neon_i<4; neon_i ++){
        // neon[neon_i].SetActive(true);}

        }
    

    // Update is called once per frame
    void Update () {

        

    }
}