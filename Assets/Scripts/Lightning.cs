using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mathf.lerp;
using Time.deltaTime;

public class Lightning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }
}
