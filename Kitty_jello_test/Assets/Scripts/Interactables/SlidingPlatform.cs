using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPlatform : Interactable {

    public Vector3 maxPos;
    public Vector3 minPos;
  
    // Use this for initialization
    public override void Start()
    {
        base.Start();
    }

    public override void Function()
    {
        transform.position = Vector3.Lerp(minPos, maxPos, value);
    }
}
