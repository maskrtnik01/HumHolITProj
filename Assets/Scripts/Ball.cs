using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public float ForceIntensity;
    public float TorqueIntensity;
    public float JumpIntensity;
    public float MaxJumpY;
    Rigidbody ballBody;
    [SerializeField] Transform ballTransform;
    void Start()
    {
        ballBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float rot = Input.GetAxis("Rotational") * TorqueIntensity;
        float hor = Input.GetAxis("Horizontal") * ForceIntensity;
        float ver = Input.GetAxis("Vertical") * ForceIntensity;
        float jmp = Input.GetAxis("Jump") * JumpIntensity;

        if (transform.position.y > MaxJumpY)
            jmp = 0;

        ballTransform.position = transform.position;
        ballTransform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        Vector3 deltaLocal = new Vector3(hor, jmp, ver);
        Vector3 deltaWorld = ballTransform.TransformDirection(deltaLocal);

        ballBody.AddForce(deltaWorld, ForceMode.Impulse);
        ballBody.AddTorque(0, rot, 0);
    }

}
