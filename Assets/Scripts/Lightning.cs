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
        //how often update will run
        perFrame = 20;
        //Maximum intensity of my lightning light
        maxIntensity = 4f;
        //what percentage I want my linear interpolation to go to
        percentageLight = .75f;
        //At what intensity of light should I end the lightning strike
        lightOff = percentageLight * maxIntensity;
    }



    // Update is called once per 30 frames
    void Update()
    {
        //random number to randomly lightning strike
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
