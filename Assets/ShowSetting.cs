using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSetting : MonoBehaviour
{
    public GameObject startUI;
    // Start is called before the first frame update


    public GameObject settingCanvas;

    public GameObject confirmLevelTwo;

    
    void Start()
    {
        
    }

    public void Showsetting()
    {
        Hashtable ht = new Hashtable();
        ht.Add("x", -1.1f);
        ht.Add("time", 1.0f);
        ht.Add("easetype", iTween.EaseType.easeOutQuad);
        ht.Add("oncompletetarget", this.gameObject);
        ht.Add("oncomplete", "SettingAppear");

        iTween.MoveTo(startUI, ht);

    }


    public void SettingAppear(){

        settingCanvas.SetActive(true);

    }

    public void Backbutton(){
        settingCanvas.SetActive(false);
        Hashtable ht = new Hashtable();
        ht.Add("x", 0.0f);
        ht.Add("time", 1.0f);
        ht.Add("easetype",iTween.EaseType.easeOutQuad);

        iTween.MoveTo(startUI, ht);

    }



public void LevelsetOne(){
    Level.level = 1;
}
    public void LevelsetTwo(){
        Level.level =2 ;
       
    }

public void LevelsetThree(){
    Level.level = 3;

}






    // Update is called once per frame
    void Update()
    {
        
    }
}
