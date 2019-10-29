using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed;
    private void Start()
    {
        speed = 5;
    }
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
