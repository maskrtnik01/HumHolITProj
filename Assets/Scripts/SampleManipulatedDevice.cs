using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleManipulatedDevice : MonoBehaviour
{
    public void OnProximityEnter()
    {
        Debug.Log("OnProximityEnter");
    }
    public void OnProximityExit()
    {
        Debug.Log("OnProximityExit");
    }
    public void OnPrimaryFunction()
    {
        Debug.Log("OnPrimaryFunction");
    }
}
