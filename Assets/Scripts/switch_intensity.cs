using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_intensity : MonoBehaviour
{
    

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.RightArrow))
            this.GetComponent<Light>().enabled = false;

        

    }
}
