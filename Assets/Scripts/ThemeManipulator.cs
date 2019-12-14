using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeManipulator : MonoBehaviour
{
    public GameObject Target;
    public void OnPrimaryFunction()
    {
        Target.SetActive(!Target.activeSelf);
    }
}
