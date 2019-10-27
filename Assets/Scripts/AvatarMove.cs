using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMove : MonoBehaviour
{
    public float RotationSpeed;
    public float MoveSpeed;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float deltaX = Input.GetAxis("Horizontal") * MoveSpeed;
        float deltaZ = Input.GetAxis("Vertical") * MoveSpeed;
        float deltaR = Input.GetAxis("Rotational") * RotationSpeed;

        transform.Rotate(0, deltaR, 0, Space.Self);
        transform.Translate(deltaX, 0, deltaZ, Space.Self);
    }
}
