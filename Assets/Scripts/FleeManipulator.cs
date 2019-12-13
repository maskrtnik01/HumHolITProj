using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class FleeManipulator : MonoBehaviour
{
    public float MoveSpeed;
    public Transform FleeFrom;
    private Vector3 Movement;
    private Rigidbody body;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetBool("Grounded", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Movement == Vector3.zero)
        {
            anim.SetFloat("MoveSpeed", 0);
        }
        else
        {
            anim.SetFloat("MoveSpeed", MoveSpeed) ;
            body.AddForce(Movement * MoveSpeed * Time.deltaTime, ForceMode.Acceleration);
        }
    }

    void OnProximityEnter()
    {
        Movement = (transform.position - FleeFrom.position).normalized;
        Movement.y = 0;
        transform.LookAt(transform.position + Movement);
    }
    void OnProximityExit()
    {
        Movement = Vector3.zero;
    }
}