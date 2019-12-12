using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarManipulator : MonoBehaviour
{
    List<GameObject> TriggersList;
    // Start is called before the first frame update
    void Start()
    {
        TriggersList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
            foreach (var trig in TriggersList)
                trig.BroadcastMessage("OnPrimaryFunction", SendMessageOptions.DontRequireReceiver);    
    }
    private void OnTriggerEnter(Collider other)
    {
        TriggersList.Add(other.gameObject);
        other.gameObject.BroadcastMessage("OnProximityEnter",SendMessageOptions.DontRequireReceiver);
    }
    private void OnTriggerExit(Collider other)
    {
        if(TriggersList.Contains(other.gameObject))
        {
            TriggersList.Remove(other.gameObject);
            other.gameObject.BroadcastMessage("OnProximityExit", SendMessageOptions.DontRequireReceiver);
        }
    }
}
