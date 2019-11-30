using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMove : MonoBehaviour
{
    public float RotationSpeed;
    public float MoveSpeed;
    public float CollisionRadius;
    public float CollisionDistance;
    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 deltaWorld;
        if(SystemInfo.supportsGyroscope)
        {
            transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
            deltaWorld = Vector3.forward * MoveSpeed;
            body.AddForce(deltaWorld, ForceMode.VelocityChange);
        }
        else
        {
            float deltaX = Input.GetAxis("Horizontal") * MoveSpeed;
            float deltaZ = Input.GetAxis("Vertical") * MoveSpeed;
            float deltaR = Input.GetAxis("Rotational") * RotationSpeed;

            deltaWorld = transform.TransformDirection(deltaX, 0, deltaZ);

            
        }
        //RaycastHit hit;
        //if (!Physics.SphereCast(transform.position, CollisionRadius, deltaWorld.normalized, out hit, CollisionDistance))
        //    transform.Translate(deltaWorld, Space.World);

    }
    private void OnGUI()
    {
    }
}
