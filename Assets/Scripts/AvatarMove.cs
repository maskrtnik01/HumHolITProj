using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMove : MonoBehaviour
{
    public float RotationSpeed;
    public float MoveSpeed;
    public float CollisionRadius;
    public float CollisionDistance;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float deltaX = Input.GetAxis("Horizontal") * MoveSpeed;
        float deltaZ = Input.GetAxis("Vertical") * MoveSpeed;
        float deltaR = Input.GetAxis("Rotational") * RotationSpeed;

        Vector3 deltaWorld = transform.TransformDirection(deltaX, 0, deltaZ);
        
        transform.Rotate(0, deltaR, 0, Space.Self);

        RaycastHit hit;
        if (!Physics.SphereCast(transform.position, CollisionRadius,deltaWorld.normalized, out hit, CollisionDistance))
            transform.Translate(deltaWorld, Space.World) ;
        
    }
}
