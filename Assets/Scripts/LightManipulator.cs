using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManipulator : MonoBehaviour
{
    public Light light;
    public void OnPrimaryFunction()
    {
        light.enabled = !light.enabled;
    }
}