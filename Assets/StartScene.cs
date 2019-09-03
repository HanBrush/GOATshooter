using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GotoPlayScene(){
        SceneManager.LoadScene("Play");
    }

public void GotoStartScene(){
    SceneManager.LoadScene("StartScene");
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
