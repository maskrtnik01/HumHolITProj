using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_intensity : MonoBehaviour
{
    public Light myLight;

    public bool changeRange = false;
    public float rangeSpeed = 1.0f;
    public float maxRange = 10.0f;

    public bool changeIntensity = false;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;

    public bool changeColor = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;

    float startTime;

    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.RightArrow))
            this.GetComponent<Light>().enabled = false;

        /*if (changeRange)
        {
            myLight.range = Mathf.PingPong(Time.time * rangeSpeed, maxRange);
        }
        if (changeIntensity)
        {
            myLight.range = Mathf.PingPong(Time.time * intensitySpeed, maxIntensity);
        }
        if (changeColor )
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            myLight.color = Color.Lerp(startColor, endColor, t);
        }*/

    }
}
