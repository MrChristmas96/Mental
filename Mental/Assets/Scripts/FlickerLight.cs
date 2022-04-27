using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    
    public Light light1;


    public float minTime;
    public float maxTime;

    public float Timer;

    void Start()
    {
        Timer = Random.Range(maxTime, minTime);
    }

     void Update()
    {
        
        LightFlick();
    }

     void LightFlick()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;

        if(Timer <= 0)
          {
             light1.enabled = !light1.enabled;
             Timer = Random.Range(minTime, maxTime);
          }

    }

}
