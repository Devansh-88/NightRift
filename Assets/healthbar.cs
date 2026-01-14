using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class healthbar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image fill;
    public float changeSpeed = 10.0f;
    public float fillAmount { get; set; } = 1.0f;
    
    
    public void Update()
    {
        fill.fillAmount = Mathf.Lerp(fill.fillAmount, fillAmount, changeSpeed*Time.deltaTime);
       
    } 

    
}
