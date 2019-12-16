using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoManipulator : MonoBehaviour
{
    private VideoPlayer plr;
    // Start is called before the first frame update
    void Start()
    {
        plr = GetComponent<VideoPlayer>();
    }
    void OnPrimaryFunction()
    {
        if (plr.isPlaying)
            plr.Stop();
        else
            plr.Play();
    }
}
