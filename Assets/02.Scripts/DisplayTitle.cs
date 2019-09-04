using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTitle : MonoBehaviour
{
    public GameObject title1;
    public GameObject title2;

    public GameObject startingUi;

public GameObject basketballPrefab_forTitle;

public Transform[] ballPos;
    // Start is called before the first frame update
    void Start()
    {
        Hashtable ht = new Hashtable();
        ht.Add("y", 0.2f);
        ht.Add("time", 2.0f);
        ht.Add("easetype", iTween.EaseType.easeOutBounce);
        ht.Add("oncompletetarget", this.gameObject);
        ht.Add("oncomplete", "Move2");

        iTween.MoveTo(title1,ht);
        
    }

    void Move2(){
        Hashtable ht = new Hashtable();
        ht.Add("y", 0.2f);
        ht.Add("time", 2.0f);
        ht.Add("easetype", iTween.EaseType.easeOutBounce);
        ht.Add("oncompletetarget", this.gameObject);
        ht.Add("oncomplete", "Dropballs");

        iTween.MoveTo(title2, ht);
    }

    void Dropballs(){
        for(int i = 0; i<8; i++){
        Instantiate(basketballPrefab_forTitle, ballPos[i].position, Quaternion.identity);
        }

        Invoke("StartUI", 1.0f);
    }

    void StartUI(){
        Hashtable ht = new Hashtable();
        ht.Add("y", 0.7);
        ht.Add("time", 1.5f);
        ht.Add("easetype", iTween.EaseType.easeInQuart);

        iTween.MoveTo(startingUi, ht);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
