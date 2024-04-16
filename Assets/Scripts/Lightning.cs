using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Lightning : MonoBehaviour
{

    int perFrame;
    float maxIntensity;
    float percentageLight;
    float lightOff;

    // Start is called before the first frame update
    void Start()
    {
        perFrame = 20;
        maxIntensity = 4f;
        percentageLight = .75f;
        lightOff = percentageLight * maxIntensity;
    }



    // Update is called once per 30 frames
    void Update()
    {
        float strike = Random.Range(0f, 10f);

        if((Time.frameCount % perFrame == 0) && (strike < 2.1f)){
            if(GetComponent<Light>().intensity < lightOff){
                GetComponent<Light>().intensity = Mathf.Lerp(GetComponent<Light>().intensity, maxIntensity, percentageLight);
            } else {
                GetComponent<Light>().intensity = Mathf.Lerp(0f, GetComponent<Light>().intensity, 0.1f);
            }
        } 
    }
}
