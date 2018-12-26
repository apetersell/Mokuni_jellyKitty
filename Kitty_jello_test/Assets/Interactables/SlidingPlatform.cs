using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPlatform : Interactable {

    Vector3 startPos;
    Vector3 InitPos;
    Vector3 offset;
    public bool Horizontal;
    public float distance;
    float min;
    float max;

	// Use this for initialization
	void Start () 
    {
        startPos = transform.position;
        if (Horizontal)
        {
            min = startPos.x - distance;
            max = startPos.x + distance;
        }
        else 
        {
            min = startPos.y - distance;
            max = startPos.y + distance;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Function()
    {
        Vector3 curScreenPoint = Vector3.zero;
        if (Horizontal)
        {
            curScreenPoint = new Vector3(Input.mousePosition.x, 0, InitPos.z);
            if (transform.position .x > min && transform.position.x < max)
            {
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                if (curPosition.x < max && curPosition.x > min)
                {
                    transform.position = curPosition;
                }
            }
        }
        else
        {
            curScreenPoint = new Vector3(0, Input.mousePosition.y, InitPos.z);
            if (transform.position.y > min && transform.position.y < max)
            {
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                if (curPosition.y < max && curPosition.y > min)
                {
                    transform.position = curPosition;
                }
            }
        }
        
    }
    public override void OnMouseDown()
    {
        InitPos = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        if (Horizontal)
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, InitPos.z));
        }
        else
        {
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(0, Input.mousePosition.y, InitPos.z));
        }
        base.OnMouseDown();
    }

}
