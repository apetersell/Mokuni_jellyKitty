using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstituantPiece : Interactable {


	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public override void Function()
    {

    }

    public override void OnMouseDown()
    {
        GameObject go = gameObject.transform.parent.gameObject;
        Interactable parent = go.GetComponent<Interactable>();
        parent.OnMouseDown();
    }
}
