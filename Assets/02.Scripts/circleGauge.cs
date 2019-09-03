using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class circleGauge : MonoBehaviour
{
    public Image _bar;
    public RectTransform button;

    public static float _gaugeValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GaugeChange(_gaugeValue);
    }

    void GaugeChange(float gaugeValue){
        float amount = (gaugeValue/100.0f) * 180.0f/360;
        _bar.fillAmount = amount;
        float buttonAngle = amount * 360;
        button.localEulerAngles = new Vector3(0,0,-buttonAngle);
    }
}
