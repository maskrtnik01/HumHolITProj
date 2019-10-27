using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrabbables : MonoBehaviour
{
    public Bounds SpawnSpace;
    public int NumGrabbables;
    public GameObject GrabbablePrefab;

    void Start()
    {
        for(int i = 0;i < NumGrabbables;i++)
        {
            float x = Random.Range(SpawnSpace.min.x, SpawnSpace.max.x);
            float y = Random.Range(SpawnSpace.min.y, SpawnSpace.max.y);
            float z = Random.Range(SpawnSpace.min.z, SpawnSpace.max.z);

            Instantiate(GrabbablePrefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }
}
