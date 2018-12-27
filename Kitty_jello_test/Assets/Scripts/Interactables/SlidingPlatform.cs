using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPlatform : Interactable {

    public float max;
    public float min;
    Vector3 minPos;
    Vector3 maxPos;
  
    // Use this for initialization
    public override void Start()
    {
        minPos = new Vector3(min, transform.position.y, transform.position.z);
        maxPos = new Vector3(max, transform.position.y, transform.position.z);
        base.Start();
    }

    public override void Function()
    {
        transform.position = Vector3.Lerp(minPos, maxPos, value);
    }
}
