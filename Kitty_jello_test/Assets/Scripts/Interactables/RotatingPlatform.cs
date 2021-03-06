﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : Interactable {

    public Quaternion hey;
    public float deltaRotation;
    public float deltaLimit;
    public float deltaReduce;
    float previousRotation;
    float currentRotation;

    public override void Start()
    {
        base.Start();
    }

    public override void Function()
    {
        //currentRotation = angleBetweenPoints(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //deltaRotation = Mathf.DeltaAngle(currentRotation, previousRotation);
        //if (Mathf.Abs(deltaRotation) > deltaLimit)
        //{
        //    deltaRotation = deltaLimit * Mathf.Sign(deltaRotation);
        //}
        //previousRotation = currentRotation;
        //transform.Rotate(Vector3.back * Time.deltaTime, deltaRotation);
    }


    void Update()
    {
        //else if (Input.GetMouseButton(0))
        //{
        //    currentRotation = angleBetweenPoints(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        //    deltaRotation = Mathf.DeltaAngle(currentRotation, previousRotation);
        //    if (Mathf.Abs(deltaRotation) > deltaLimit)
        //    {
        //        deltaRotation = deltaLimit * Mathf.Sign(deltaRotation);
        //    }
        //    previousRotation = currentRotation;
        //    transform.Rotate(Vector3.back * Time.deltaTime, deltaRotation);
        //    Debug.Log("Should be rotating");
        //}
        //else
        //{
        //    transform.Rotate(Vector3.back * Time.deltaTime, deltaRotation);
        //    deltaRotation = Mathf.Lerp(deltaRotation, 0, deltaReduce * Time.deltaTime);
        //}

    }

    float angleBetweenPoints(Vector2 position1, Vector2 position2)
    {
        Vector2 fromLine = position2 - position1;
        Vector2 toLine = new Vector2(1, 0);

        float angle = Vector2.Angle(fromLine, toLine);

        Vector3 cross = Vector3.Cross(fromLine, toLine);

        // did we wrap around?
        if (cross.z > 0)
        {
            angle = 360f - angle;
        }

        return angle;
    }
}
