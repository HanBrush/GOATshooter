using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSetting : MonoBehaviour
{
    public GameObject startUI;
    // Start is called before the first frame update


    public GameObject settingCanvas;
    void Start()
    {
        
    }

    public void Showsetting()
    {
        Hashtable ht = new Hashtable();
        ht.Add("x", -1.4f);
        ht.Add("time", 1.0f);
        ht.Add("easetype", iTween.EaseType.easeOutQuad);
        ht.Add("oncompletetarget", this.gameObject);
        ht.Add("oncomplete", "SettingAppear");

        iTween.MoveTo(startUI, ht);

    }


    void SettingAppear(){

        settingCanvas.SetActive(true);

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
