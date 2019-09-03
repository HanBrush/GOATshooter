using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountDoownScript : MonoBehaviour
{
    public Text uiText;
    public float mainTimer;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    public float secs;
    public float mins;
    

    void Start()
    {
        timer = mainTimer;
    }
    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            
            //uiText.text = timer.ToString("F");
            
            uiText.text = ""+GetMinute((int)timer)+" : "+GetSeconds((int)timer)+"";
            //아래서불러온값에분과초를입력
        }
      
        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            GameOver();
        }
    }
    int GetMinute(int time)
    {
        return(time/60)%60;
        //초를60으로나눈값
    }
    int GetSeconds(int time)
    {
        return(time%60);
        //초를60으로나누고난나머지
    }
    public void ResetBtn()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
        uiText.text = timer.ToString("F");
        
    }
    void GameOver()
    {
        //Load a new scene
    }
}