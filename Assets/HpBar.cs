using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider hpSlider;

    public void InitBar(float maxValue) 
    {
        hpSlider.maxValue = maxValue;
        hpSlider.value = maxValue;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
     public void SetValue(float hpvalue)
        {
        hpSlider.value = hpvalue;
        }
}
